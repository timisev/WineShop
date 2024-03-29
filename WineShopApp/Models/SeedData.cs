﻿using Microsoft.EntityFrameworkCore;

namespace WineShopApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if(context.Categories.Any())
                {
                    return;
                }
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Белое"
                    },
                    new Category
                    {
                        Name = "Красное"
                    });
                context.SaveChanges();

                if (context.Wines.Any())
                {
                    return;
                }
                context.Wines.AddRange(
                    new Wine
                    {
                        Name = "Familia Bastida, \"Talma\" Syrah",
                        Description = "\"Talma\" Syrah — элегантное и свежее красное сухое вино, в производстве которого виноделы используют виноград сорта Сира, выращенный на виноградниках компании в регионе Мурсия на высоте 600-800 метров над уровнем моря. Сбор урожая проводится лишь по достижении ягодами оптимального уровня спелости, на винодельне плоды подвергаются прессованию с последующей винификацией, проходящей в стальных емкостях со строгим температурным контролем. Половина вина выдерживается в дубовых бочках на протяжении 3 месяцев для получения более сложного вкуса. Подробнее: https://winestyle.ru",
                        Price = 995,
                        Year = "2022",
                        CategoryId = 2
                    },
                    new Wine
                    {
                        Name = "Connoisseur, \"L'Eternelle Fidele\" Colombard-Ugni Blanc, Cotes de Gascogne IGP",
                        Description = "Вина бренда \"Connoisseur\" производятся на винодельне Domaine Haut Marin, принадлежащей семье Йегерленер-Пратавьера из Гаскони. Винодельня Domaine Haut Marin расположена посреди древнего морского залива в Гаскони, на пути Святого Иакова, ведущего в Сантьяго-ди-Компостела. Все вина производятся из классических для региона сортов винограда и поступают на рынок после минимум трех месяцев выдержки в стальных чанах. Все вина Домена О Марен классифицируются Cotes de Gascogne IGP. За винификацию отвечает владелица хозяйства и энолог Элизабет Пратавьера. \r\nНазвание линейки \"Connoisseur\" переводится с французского как \"знаток, ценитель\", она создана из автохтонных для Гаскони сортов и предназначена для искушенных винолюбов. Подробнее: https://winestyle.ru",
                        Price = 899,
                        Year = "2022",
                        CategoryId = 2 
                    },
                    new Wine
                    {
                        Name = "\"Cibolo\" Sauvignon Blanc",
                        Description = "\"Cibolo\" Sauvignon Blanc — элегантное белое сухое вино, созданное из винограда сорта Совиньон Блан. Совиньон Блан — сорт, который не нуждается в представлении. Это гарантия ароматности и легкого стиля. Виноград выращивается в теплом районе Хумилья, но на высоте 700-800 метров над уровнем моря, благодаря чему вино сохраняет свойственную ему высокую кислотность и освежающий характер. Сбор урожая проводится по достижении ягодами оптимальной спелости, на винодельне плоды подвергаются мягкому прессованию с последующей ферментацией со строгим температурным контролем. Непродолжительная выдержка осуществляется в стальных чанах. \"Сиболо\" Совиньон Блан является идеальным компаньоном для морепродуктов, легких закусок или птицы. Подробнее: https://winestyle.ru",
                        Price = 1096,
                        Year = "2022",
                        CategoryId = 1 
                    },
                    new Wine
                    {
                        Name = "Cantine Risveglio, \"Sciaia\", Puglia IGT",
                        Description = "Cantine Risveglio, \"Sciaia\", Puglia IGT — элегантное белое сухое вино, изготовленное из винограда сортов Шардоне и Мальвазия. Возраст виноградных лоз колеблется от 10 до 20 лет. Сбор урожая осуществляется механическим способом во второй декаде августа. На винодельне плоды подвергаются мягкому дроблению с последующим дестеблированием и ферментацией в стальных резервуарах при контролируемой температуре в течение 10-12 дней. Выдерживается вино непродолжительное время в бочках из дуба Алье (около 1 месяца). Подробнее: https://winestyle.ru",
                        Price = 1294,
                        Year = "2022",
                        CategoryId = 1
                    },
                    new Wine
                    {
                        Name = "\"Corkout\" Zweigelt",
                        Description = "\"Corkout\" Zweigelt — красное сухое вино, созданное из винограда сорта Цвайгельт. Виноград произрастает на юго-востоке Бургенланда на границе с Венгрией. Средний возраст виноградных лоз составляет 15-20 лет. По окончании сбора урожая плоды подвергаются прессованию с последующей винификацией, проходящей в стальных резервуарах со строгим температурным контролем. Выдерживается вино непродолжительное время в чанах из нержавеющей стали.\r\n\r\n2021 год подарил Австрии зрелые, кристально чистые, элегантные, очень сочные и концентрированные вина, о которых, вероятно, еще долго будут говорить, как о выдающихся. Зима выдалась сухой и солнечной. Март был довольно прохладным и влажным, из-за чего бутонизация наступила позже, чем в предыдущие годы. Прохладная и влажная погода преобладала также в апреле и мае. Позднее цветение длилось несколько недель. Июль и август были очень благоприятными, что способствовало отличному развитию лозы. Сухая и теплая осень создала идеальные условия для созревания урожая. Виноград был исключительного качества, хотя урожайность была несколько ниже, чем ожидалось.\r\n\r\nВ мире известно немало историй успешных сомелье, которые после многих лет работы в ресторанах решаются кардинально изменить свою жизнь и переходят на \"другую\" сторону — становятся виноделами. Кто-то совмещает работу в ресторане и производство вин под собственный брендом. Всеми движет одна и та же цель — создать вино, которое восхитит, понравится не только производителю и идейному вдохновителю, но и получит похвалы от друзей, товарищей по цеху и соседей.\r\n\r\nПодробнее: https://winestyle.ru",
                        Price = 1101,
                        Year = "2021",
                        CategoryId = 2 
                    });
                context.SaveChanges();
            }
        }
    }
}
