using Kepsi.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeepItShort.Persistance.Models;

namespace Kepsi.Dal.Seed
{
    internal static class EmailsSeed
    {
        internal static void AddEmail(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasData(new Email()
                {
                    Id = 1,
                    ConversationId = 1,
                    AddedDate = DateTime.Now,
                    Content = "Temat: Zapytanie w Sprawie Mojej Aktualnej Sytuacji  Do firmy windykacyjnej,  Nazywam się Jan Kowalski i chciałbym uzyskać aktualne informacje dotyczące mojej sprawy windykacyjnej. Ostatnio otrzymałem kilka pism od Waszej firmy, ale potrzebuję więcej szczegółów na temat postępu w mojej sprawie.  Proszę o udzielenie odpowiedzi na następujące pytania:  Jaka jest aktualna kwota mojego zadłużenia? Czy są jakieś dodatkowe opłaty lub koszty, o których powinienem wiedzieć? Jakie kroki podejmujecie w związku z moją sprawą i jakie są kolejne etapy procesu? Rozumiem, że obowiązek spłaty długu spoczywa na mnie, ale chciałbym lepiej zrozumieć, w jakim punkcie znajduje się obecnie ta sprawa i jakie są moje opcje.  Proszę o udzielenie jasnych informacji, które pomogą mi lepiej zrozumieć sytuację.  Z góry dziękuję za odpowiedź.  Z poważaniem,  Jan Kowalski 111 222 333 jk@test.com"
                });

            modelBuilder.Entity<Email>()
                .HasData(new Email()
                {
                    Id = 2,
                    ConversationId = 1,
                    AddedDate = DateTime.Now,
                    Content = "Temat: Hmmm... Sprawa Jakaś Tam  Cześć Janek,  No witaj! Okej, coś tam sprawdziliśmy i tak... masz jakiś dług u nas. Trochę tu, trochę tam, ale ogólnie luz. Nie przejmuj się, to tylko formalność. Na pewno szybko to ogarniemy.  Co do szczegółów, no wiesz, nie bierz tego tak na poważnie. Dług to dług, ale przecież każdy ma jakieś rachunki do spłacenia, nie? Trochę zabawy z dokumentami, kilka telefonów, i już będzie po sprawie. To nic takiego.  Jakieś pytania? Ech, szkoda nerwów! Po co te wszystkie detale? Wszystko się poukłada, a do tego czasu... no cóż, życie.  Piona, Adaś Kruk 222 333 444 adas@buziaczek.pl"
                });

            modelBuilder.Entity<Email>()
                .HasData(new Email()
                {
                    Id = 3,
                    ConversationId = 1,
                    AddedDate = DateTime.Now,
                    Content = "Temat: Zgłoszenie Sprawy do Pracodawcy  Dzień dobry,  Chciałem wyrazić swoje rozczarowanie w związku z tonem i treścią Pańskiego ostatniego maila. Mam wrażenie, że nie zrozumiał Pan powagi mojej sytuacji finansowej i sposób, w jaki zostałem potraktowany, nie przystaje do standardów profesjonalizmu.  Rozumiem, że wszyscy mamy swoje obowiązki, ale oczekuję jednak pewnego szacunku w trakcie komunikacji, szczególnie w kontekście spraw finansowych. Wasza reakcja wydaje mi się mało profesjonalna.  Informuję, że zrzekam się dalszej korespondencji mailowej i zgłaszam tę sytuację do Państwa pracodawcy. Uważam, że taka forma komunikacji nie jest akceptowalna i mam nadzieję, że zostanie to wzięte pod uwagę w kontekście szkoleń dotyczących obsługi klienta.  Czekam na informację zwrotną w tej sprawie.  Z poważaniem,  Jan Kowalski 111 222 333 jk@test.com"
                });

            modelBuilder.Entity<Email>()
                .HasData(new Email()
                {
                    Id = 4,
                    ConversationId = 1,
                    AddedDate = DateTime.Now,
                    Content = "Temat: Zgłoszenie Sprawy do Pracodawcy  Dzień dobry,  Chciałem wyrazić swoje rozczarowanie w związku z tonem i treścią Pańskiego ostatniego maila. Mam wrażenie, że nie zrozumiał Pan powagi mojej sytuacji finansowej i sposób, w jaki zostałem potraktowany, nie przystaje do standardów profesjonalizmu.  Rozumiem, że wszyscy mamy swoje obowiązki, ale oczekuję jednak pewnego szacunku w trakcie komunikacji, szczególnie w kontekście spraw finansowych. Wasza reakcja wydaje mi się mało profesjonalna.  Informuję, że zrzekam się dalszej korespondencji mailowej i zgłaszam tę sytuację do Państwa pracodawcy. Uważam, że taka forma komunikacji nie jest akceptowalna i mam nadzieję, że zostanie to wzięte pod uwagę w kontekście szkoleń dotyczących obsługi klienta.  Czekam na informację zwrotną w tej sprawie.  Z poważaniem,  Adam Nowak 222 333 444 anowak@kruk.pl"
                });
        }
    }
}
