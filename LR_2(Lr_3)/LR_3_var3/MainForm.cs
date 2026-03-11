using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_3_var3
{
    public partial class MainForm: Form
    {
        private Dictionary<string, List<Films>> film_ = new Dictionary<string, List<Films>>();
        private Dictionary<string, List<Films>> kino_ = new Dictionary<string, List<Films>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileDrugStorage fileDrugStorage = new FileDrugStorage();
        public MainForm()
        {
            InitializeComponent();
            FotoPictureBox.Size = new Size(190, 270);
            FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            kino_.Add("Фэнтези",
                new List<Films>()
                {
                    new Films("Очень странные дела", "Действие разворачивается в 1980-х годах \n" +
                " в вымышленном городке Хоукинс (штат Индиана). Расположенная неподалёку \n" +
                "Национальная лаборатория Хоукинса якобы проводит научные исследования для \n" +
                "Министерства энергетики США, но на самом деле тайно занимается экспериментами в \n" +
                "области паранормальных и сверхъестественных явлений. Во время одного из своих \n" +
                "экспериментов сотрудники лаборатории случайно открывают портал в альтернативное \n" +
                "измерение — «Изнанку» \n", "Братья Дафферы",
                "16.02.2026", 2000, 6, "111.jpg"),
                    new Films("Уэнздей", "Уэнздей, дочь Гомеса и Мортиши Аддамс, учится в академии \n" +
                    " Nevermore. Ей предстоит освоить экстрасенсорные способности, чтобы остановить \n" +
                    "местного серийного убийцу и раскрыть тайну родителей.", "Тим Бёртон", "20.02.2026", 2000, 3, "000.jpg")
                }
            );

            kino_.Add("Комедия",
                new List<Films>()
                {
                    new Films("Дряные девчонки", "Проведя детство в Африке с родителями-зоологами, \n " +
                    "Кэйди Хэрон думала, что знает всё про правило «выживает сильнейший». Но закон \n " +
                    "джунглей полностью пересматривается, когда домашняя 15-летняя девушка в первый раз \n " +
                    "попадает в обычную школу и влюбляется в бывшего парня самой популярной девчонки в школе.", "Марк Уотерс", "08.03.2026", 300, 7, "1234.jpg"),
                    new Films("Одноклассники", "5 друзей детства встречаются после 30 лет разлуки в \n" +
                    "летнем доме у озера на уик-энд в День независимости. Они приехали сюда с семьями, \n" +
                    "чтобы почтить память школьного тренера по баскетболу и отпраздновать тридцатую \n" +
                    "годовщину чемпионата, в котором они вместе выиграли.", "Деннис Дуган", "13.03.2026", 300, 5, "154.jpg")
                }
            );
            kino_.Add("Драма",
                new List<Films>()
                {
                    new Films("Дьявол носит прада", "Мечтающая стать журналисткой провинциальная \n " +
                    "девушка Энди по окончании университета получает должность помощницы всесильной \n " +
                    "Миранды Пристли, деспотичного редактора одного из крупнейших нью-йоркских журналов \n " +
                    "мод. Энди всегда мечтала о такой работе, не зная, с каким нервным напряжением \n" +
                    "это будет связано…", "Дэвид Фрэнкел", "20.03.2026", 500, 4, "666.jpg"),
                    new Films("Одинь день", "Эмма романтична, остра на язык и хочет изменить мир к \n" +
                    "лучшему. Декстер — плейбой, баловень судьбы и хочет, чтобы мир принадлежал ему. \n" +
                    "Впервые они встретились на выпускном в колледже и провели вместе только один день. \n" +
                    "А потом пришла ночь, и они решили остаться друзьями.", "Лоне Шерфиг", "15.02.2026", 400, 3, "333.jpg")
                }
            );
            kino_.Add("Приключения",
                new List<Films>()
                {
                    new Films("Алиса в зазеркалье", "На этот раз главной героине предстоит отправиться \n" +
                    "в путешествие во времени, полное неожиданностей и ярких открытий, чтобы спасти \n" +
                    "своего друга, Безумного Шляпника.", "Тим Бёртон", "09.02.2026", 400, 2, "999.jpg"),
                    new Films("Энола Холмс", "В 1884 году Энола Холмс в день 16-летия узнаёт, \n" +
                    "что её мама пропала, и обращается за помощью к братьям, но они не поддерживают \n" +
                    "её. Энола не соответствует общепринятому представлению о приличной молодой особе, \n" +
                    "и Майкрофт собирается отправить её в женский пансион. Энола решает сбежать на поиски \n" +
                    "мамы и по пути встречает виконта, который тоже сбежал от своей родни.", "Гарри Брэдбир", "20.02.2026", 1900, 10, "098.jpg")
                }
            );
            
            List<string> st_name = kino_.Keys.ToList();
            FilmsListBox.DataSource = st_name;

            StringBuilder reportBuilder = new StringBuilder();

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Films st_name = FilmsComboBox.SelectedItem as Films;
            LabelNaimenowanie.Text = "Наименование: ";
            LabelOpisanie.Text = "Описание: " + st_name.Opisanie;
            LabelRecjiser.Text = "Режисёр: " + st_name.Rejiser;
            LabelDate.Text = "Прокат до: " + st_name.Date;
            LabelSum.Text = "Стоимость билета: " + st_name.Summ + " руб.";
            LabelNumber.Text = "Осталось прокатов: " + st_name.Number;
            if (st_name.Foto != null)
            {
                FotoPictureBox.Image = Image.FromFile(st_name.Foto);
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string  st_name = FilmsListBox.SelectedItem.ToString();
            List<Films> films = kino_[st_name];

            FilmsComboBox.DataSource = films;
            FilmsComboBox.DisplayMember = "Name";
        }

        private void OtchetButton_Click(object sender, EventArgs e)
        {
            

            string genre = FilmsListBox.SelectedItem as string;
            // Получаем список фильмов для этого жанра
            if (kino_.TryGetValue(genre, out List<Films> films))
            {
                // Очищаем RichTextBox перед выводом
                RichTextBox.Clear();

                // Перебираем все фильмы и выводим их информацию
                foreach (var film in films)
                {
                    RichTextBox.AppendText($"Название: {film.Name}, ");
                    RichTextBox.AppendText($"Осталось прокатов: {film.Number}\n");
                }
            }

        }

        private void Button_dobav_Click(object sender, EventArgs e)
        {
            Films selectedFilms = FilmsComboBox.SelectedItem as Films;
            if (selectedFilms != null)
            {
                string drugName = selectedFilms.Name;
                int quantity = (int)NumericUpDown.Value;
                if (orderItems_.ContainsKey(drugName))
                {
                    orderItems_[drugName] += quantity;
                }
                else
                {
                    orderItems_[drugName] = quantity;
                }

                string orderText = "Заказано показов:\n";
                foreach (var item in orderItems_)
                {
                    orderText += $"{item.Key}: {item.Value}.\n";

                }

                MessageBox.Show(orderText, "Текущий заказ");
            }
        }
    }
}
