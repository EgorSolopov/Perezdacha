using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace task8_26
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            AddActor(new TechnicsWrapper(new SlowTechnics()));
            AddActor(new TechnicsWrapper(new FastLoader()));
            AddActor(new House("First"));
            AddActor(new House("Second"));
            AddActor(new House("Third"));
            AddActor(new House("Fourth"));
        }

        private void AddActor(Actor actor)
        {
            var view = new ListBox();
            view.Items.Add($"Тип: {actor.GetType().Name}");
            view.Items.Add($"Имя: {actor.Name}");
            view.Items.Add($"Состояние: нет");
            view.Size = new Size(340, 50);
            actor.ActorEvent += state => view.Items[2] = $"Состояние: {state}";
            this.Panel.Controls.Add(view);
        }

        private void AddBolide_Click(object sender, EventArgs e) {
            var rnd = new Random();
            var rndName = string.Join("", Enumerable.Range(1, 4).Select(x => rnd.Next(64, 90)).Select(x => (char)x));
            AddActor(new House(rndName));
        }

        private void SlowLoader_Click(object sender, EventArgs e)
        {
            AddActor(new TechnicsWrapper(new SlowTechnics()));
        }

        private void FastLoader_Click(object sender, EventArgs e)
        {
            AddActor(new TechnicsWrapper(new FastLoader()));
        }

        private void InstantLoader_Click(object sender, EventArgs e)
        {
            AddActor(new TechnicsWrapper(new InstantTechnics()));
        }
    }
}
