using System.Collections.Concurrent;

namespace PSP_E1_Ariketa_8_Download_Simulator
{
    public partial class Form1 : Form
    {
        // Fitxategi objektuak gordeko dituen BlockingCollection zerrenda.
        BlockingCollection<Fitxategia> blockingCollectionFitxategiak = new BlockingCollection<Fitxategia>();

        public Form1()
        {
            InitializeComponent();

            // Sortu fitxategien objektuak.
            Fitxategia f1 = new Fitxategia("Fitxategi 1", 100);
            Fitxategia f2 = new Fitxategia("Fitxategi 2", 200);
            Fitxategia f3 = new Fitxategia("Fitxategi 3", 80);
            Fitxategia f4 = new Fitxategia("Fitxategi 4", 250);
            Fitxategia f5 = new Fitxategia("Fitxategi 5", 180);
            // Gehitu blocking collection zerrendara.
            blockingCollectionFitxategiak.Add(f1);
            blockingCollectionFitxategiak.Add(f2);
            blockingCollectionFitxategiak.Add(f3);
            blockingCollectionFitxategiak.Add(f4);
            blockingCollectionFitxategiak.Add(f5);
            blockingCollectionFitxategiak.CompleteAdding();
        }

        private void deskargatu(int progressBar)
        {
            // Aukeratu eguneratuko dugun Progress Bar jasotako argumentuaren arabera.
            ProgressBar auxProgressBar = (progressBar == 1) ? this.progressBar1 : this.progressBar2;
            // Aukeratu eguneratuko dugun Laberal jasotako argumentuaren arabera.
            Label auxLabel = (progressBar == 1) ? this.labelDeskarga1 : this.labelDekarga2;
            
            // Fitxategi biltegian elementuak dauden bitartean.
            while (!blockingCollectionFitxategiak.IsCompleted)
            {
                // Hartu elementua.
                Fitxategia f = blockingCollectionFitxategiak.Take();

                // Hasieratu ProgressBar.
                auxProgressBar.Minimum = 0;
                auxProgressBar.Maximum = 100;
                auxProgressBar.Value = 0;
                // Eguneratu jaisten ari garen fitxategiaren izena.
                auxLabel.Text = f.Izena + " " + f.Tamaina + "MB / 0MB";

                // Simulatu 200ms-duro 10MB jaisten ditugula.
                int blockSize = 10;
                for (int downloaded = 0; downloaded <= f.Tamaina; downloaded += blockSize)
                {
                    // Eguneratu jaisten ari garen fitxategiaren izena.
                    auxLabel.Text = f.Izena + " " + f.Tamaina + "MB / " + downloaded + "MB";
                    // Kalkulatu fitxategiaren zenbat portzentai jaitsi dugun.
                    int progressPercentage = (int)((double)downloaded / f.Tamaina * 100);
                    // Eguneratu ProgressBar balioa.
                    auxProgressBar.Value = progressPercentage;
                    // Itxaron 200ms sarea simulatzeko.
                    Thread.Sleep(200);
                }

                auxProgressBar.Value = 100;
                // Adierazi TextArean fitxategia jaitsi dela.
                this.textBox1.AppendText(f.Izena + " (" + f.Tamaina + ") OK!\n");
            }
        }

        private void buttonHasi_Click(object sender, EventArgs e)
        {
            // Sortu lehenengo ataza.
            Task.Run(() => deskargatu(1));
            // Sortu bigarren ataza.
            Task.Run(() => deskargatu(2));
        }
    }
}
