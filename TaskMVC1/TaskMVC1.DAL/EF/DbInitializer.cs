using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskMVC1.DAL.Entities;
using System.IO;
using System.Drawing;

namespace TaskMVC1.DAL.EF
{
    /// <summary>
    /// Database initializer.
    /// </summary>
    class DbInitializer:DropCreateDatabaseAlways<BlogContext>
    {
        protected virtual List<Kind> CreateKinds()
        {
            List<Kind> kinds = new List<Kind>();
            kinds.Add(new Kind() { Name = "Спортивные" });
            kinds.Add(new Kind() { Name = "Комфортные" });
            kinds.Add(new Kind() { Name = "Надежные" });
            kinds.Add(new Kind() { Name = "Красивые" });
            kinds.Add(new Kind() { Name = "Новые" });
            kinds.Add(new Kind() { Name = "Популярные" });
            return kinds;
        }

        protected virtual List<Article> CreateArticles()
        {
            List<Article> articles = new List<Article>();
            var kinds = CreateKinds();
            articles.Add(new Article
            {
                Date = new DateTime(2019, 09, 09),
                Text = "На честь 35-летия культового автомобиля ограниченной серией (4628 штук) была выпущена модель Limited Edition GT. Автомобиль выпускался с семнадцатидюймовыми дисками, серебристой кожаной отделкой салона и в четырёх цветах: красном, серебристом, белом и чёрном. Во все юбилейные годы, с 1999 по 2004, на передних шильдиках выпускаемых мустангов красовались надписи «35th Anniversary» и «40th Anniversary». В 2001 году компанией Форд были выпущена ограниченная серия Ford Mustang Bullit, названная так в честь одноимённого фильма, вышедшего в 1968 году, где с участием Ford Mustang G.T.390, показана одна из самых эффектных погонь в мировом кинематографе. Интересно, что на этих кадрах мустанг развивает скорость до 175 км/час, а сама погоня длится 9 минут 42 секунды (время съёмок заняло три недели). Тот самый тёмно-зелёный мустанг, участвовавший в кинематографической погоне, с тех пор сменил несколько владельцев и теперь не на ходу.",
                Title = "GT Fastback 2019",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\First.jpg"),
                Kinds=new List<Kind>() {kinds[0],kinds[1],kinds[2] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2019, 08, 12),
                Text = "Версия модели Bullit 2001 года была не очень успешной и, по мнению многих, за громким название Bullit и шильдиками не крылось ничего выдающегося. Спустя 40 лет после выхода фильма на экраны, конструкторы решили возродить марку автомобиля. И в 2008 году миру был представлен новый, обновлённый Ford Mustang Bullit. За экстерьером, почти полностью повторяющим свою звёздную копию из кинофильма, кроется современная «начинка». Автомобиль, на котором по традиции нет шильдиков и эмблемы с бегущей дикой лошадкой, покоряет своими, отполированными до блеска металлическими, а не хромированными, деталями и новыми колёсами с литыми дисками. Динамика поддерживается мощным двигателем, объёмом 4,6 литров и развиваемым мощность в 416 лошадиных сил. Таким образом, Ford Mustang Bullit образца 2008 года считается одним из мощнейших «гражданских» автомобилей с максимально развиваемой скоростью до 240 км/час. Машина оснащена современными системами по управлению и безопасности вождения автомобилем.  В настоящее время осуществляется продажа ограниченного тиража Ford Mustang Bullit (7 700 единиц) в Америке и Канаде.",
                Title = "GT by Designo Motoring",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Second.jpg"),
                Kinds = new List<Kind>() { kinds[4], kinds[5], kinds[0] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2019, 07, 11),
                Text = "Вершиной удачного развития Ford Mustang является его модификация от Shelby. Удачное сотрудничество с корпорацией Форд известного американского автогонщика Кэролла Шэлби, который не мог уже к тому времени заниматься спортом из-за проблем с сердцем, и воплотилось в создании Shelby Cobra. Сразу обратив внимание на первый вышедший Мустанг, и разглядев в нём спортивное будущее, конструктор принялся за доработку только что созданного нового автомобиля. Так, был обновлён и доработан двигатель, увеличена его мощность с 271 лошадиных сил до 306 л.с. Чтобы значительно снизить массу, в гоночных версиях модель лишилась задних сидений, а капот был сделан из стеклопластика. Эти усилия привели к тому, что Shelby Cobra «похудела» аж на 1270 килограмм. Шэлби того периода смог разгоняться за 6,5 секунд и развивать скорость до 217 км/час.",
                Title = "GT on Vossen Wheels",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Thirt.jpg"),
                Kinds = new List<Kind>() { kinds[1], kinds[2], kinds[3] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2018, 12, 12),
                Text = "Яркая звезда, взошедшая на небосклон в шестидесятых годах – Shelby – стала настоящей добычей для коллекционеров раритетных автомобилей. Особое благоговение они испытывают к легендарной Shelby GT500 Eleanor. Машина под таким названием вошла в кадры фильма «Угнать за 60 секунд» и, бесспорно, сыграла в нём главную роль. Сердце замирает, находясь рядом с таким автомобилем, и это нечто (восторг, почитание) не отпускает уже никогда, хочется снова и снова любоваться его контурами!",
                Title = "GT Performance Pack 2",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Fourth.jpg"),
                Kinds = new List<Kind>() { kinds[4], kinds[5], kinds[0] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2018, 11, 4),
                Text = "С начала 2000-х годов Кэрол Шэлби вновь приступил к работе совместно с компанией Форд. Результатом их сотрудничества стали Shelby GT и GT-H. Позже был возрождён и Mustang Shelby GT500. Мощность двигателя довели до 660 лошадиных сил. Самый быстрый из семейства мустангов, автомобиль GT500 способен разогнаться до 325 км/час всего за 3,7 секунд.",
                Title = "EcoBoost TJIN",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Fiveth.jpg"),
                Kinds = new List<Kind>() { kinds[1], kinds[2], kinds[3] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2018, 05, 22),
                Text = "Shelby Cobra с мощным семилитровым мотором и 355 «лошадок» появилась в 1967 году. Обновился дизайн, добавилась модель в виде кабриолета, а на радиаторной решётке стала красоваться кобра – эмблема авто. На нескольких экземплярах были поставлены двигатели с тем же семилитровым объёмом, но способными выдавать «на гора» 500 лошадиных сил. Такие автомобили развивали скорость до фантастических 270 километров за час.",
                Title = "Raptor",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Sixth.jpg"),
                Kinds = new List<Kind>() { kinds[5], kinds[4], kinds[0] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2018, 03, 15),
                Text = "Солидный пятидесятилетний юбилей автомобиля Ford Mustang  компания решила ознаменовать появленим новой модели. В декабре 2014 года продолжение легенды американского автопрома продемонстрировали на автосалоне в Детройте. Автомобиль получил двигатели EcoBoost объёмом 2,3 и 5,0 литров. В перечне обновлений – новый экстерьер, фары и опции. Продажи любимца автомобильной публики начнутся в 2015 году.",
                Title = "Eagle Squadron",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Seventh.jpg"),
                Kinds = new List<Kind>() { kinds[1], kinds[2], kinds[3] }
            });
            articles.Add(new Article
            {
                Date = new DateTime(2018, 01, 01),
                Text = "Shelby GT350 вышла дороже своего «собрата» обычного Мустанга. Поэтому был придуман неплохой маркетинговый ход – готовые автомобили cдавали в аренду. Часто этим пользовались гонщики непрофессионалы, возвращая автомобиль с номерами на дверях и наклейками на капоте. Shelby Cobra с мощным семилитровым мотором и 355 «лошадок» появилась в 1967 году. Обновился дизайн, добавилась модель в виде кабриолета, а на радиаторной решётке стала красоваться кобра – эмблема авто. На нескольких экземплярах были поставлены двигатели с тем же семилитровым объёмом, но способными выдавать «на гора» 500 лошадиных сил. Такие автомобили развивали скорость до фантастических 270 километров за час.",
                Title = " Mustang by CWDesign",
                Photo = _fileToBytes(@"C:\Users\User\source\repos\TaskMVC1\TaskMVC1.DAL\Images\Eighth.jpg"),
                Kinds = new List<Kind>() { kinds[3], kinds[5], kinds[1] }
            });
            return articles;
        }

        protected virtual List<Review> CreateReviews() {
            List<Review> reviews = new List<Review>();
            reviews.Add(new Review()
            {
                Date = new DateTime(2019, 06, 12),
                Name = "Кулешов Арнольд",
                Text = "Все очень интересно и понятно."
            });
            reviews.Add(new Review()
            {
                Date = new DateTime(2019, 01, 06),
                Name = "Иванов Евгений",
                Text = "Купил свой первый мустанг, очень рад."
            });
            reviews.Add(new Review()
            {
                Date = new DateTime(2018, 12, 12),
                Name = "Демченко Роман",
                Text = "Считаю, что это лучшая марка авто."
            });
            reviews.Add(new Review()
            {
                Date = new DateTime(2018, 11, 11),
                Name = "Солодовников Василий",
                Text = "Скоро накоплю на последнюю модель."
            });
            reviews.Add(new Review()
            {
                Date = new DateTime(2018, 09, 12),
                Name = "Марченко Эдуард",
                Text = "Считаю, что мощность важнее внешнего вида."
            });
            return reviews;
        }

        protected virtual List<Tag> CreateTags()
        {
            List<Tag> tags = new List<Tag>();
            tags.Add(new Tag() { Text = "Полный привод" });
            tags.Add(new Tag() { Text = "Бронированные стекла" });
            tags.Add(new Tag() { Text = "Парамагнитная покраска" });
            tags.Add(new Tag() { Text = "Повышенный комфорт" });
            tags.Add(new Tag() { Text = "Гоночный тюнинг" });
            return tags;
        }

        protected virtual List<Vote> CreateVotes()
        {
            List<Vote> votes = new List<Vote>();
            votes.Add(new Vote() { Name = "Я из Украины", Count = 111 });
            votes.Add(new Vote() {Name="Я из России", Count = 222 });
            votes.Add(new Vote() {Name="Я из Америки", Count = 333 });
            votes.Add(new Vote() {Name="Я из другой страны", Count = 444 });
            return votes;
        }

        protected virtual List<Complectation> CreteComplectation()
        {
            List<Complectation> complectations = new List<Complectation>();
            complectations.Add(new Complectation() { Name = "Эконом" });
            complectations.Add(new Complectation() { Name = "Стандарт" });
            complectations.Add(new Complectation() { Name = "Максимум" });
            return complectations;
        }

        /// <summary>
        /// Create database with test data.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(BlogContext context)
        {
            var articles = CreateArticles();
            context.Articles.AddRange(articles);
            var reviews = CreateReviews();
            context.Reviews.AddRange(reviews);
            var tags = CreateTags();
            context.Tags.AddRange(tags);
            var complectations = CreteComplectation();
            context.Complectations.AddRange(complectations);
            var votes = CreateVotes();
            context.Votes.AddRange(votes);
            base.Seed(context);
        }

        private byte[] _fileToBytes(string path)
        {
            Image image = Image.FromFile(path);
            MemoryStream memory = new MemoryStream();
            image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] i = memory.ToArray();
            return i;
        }
    }
}
