
# Aplikacja Helpdesk

Projekt zaliczeniowy, przedstawiający aplikacje internetową o tematyce Helpdesk.




## Autor

- [Jakub Kołodziej](https://github.com/JakubKolodziej21) nr. indeksu 14128


## Opis aplikacji

Aplikacja to prosta strona przeznaczona dla pracowników IT, którzy pracują jako Wsparcie techniczne i walczą z zgłoszeniami użytkowników jednocześnie chcąć sobie to wszystko uporządkować.

Użytkownik, który nie ma uprawnień administratora, może za pomocą formularza stworzyć zgłoszenie, które następnie pracownik it lub administrator wyświetlą za pomocą swojej osobnej części aplikacji.

`Użytkownik` ma prawo do utworzenia zgłoszenia,


`Administrator` ma prawo do Utworzenia, Edycji, Przeglądania, Usuwania:

-Zgłoszeń, Użytkowników, Urządzeń





## Dane do logowania:

Aby zalogować się do aplikacji, możemy skorzystać z następujących kont:

`Administrator`


E-mail: root@admin.pl

Hasło:  12341234

#

`Alicja Kowal`


E-mail: akowal@gmail.com

Hasło:  12345678

`Jakub Kołodziej`


E-mail: jakub.kolodziej28@microsoft.wsei.edu.pl

Hasło:  12345678

## Testowanie aplikacji

Najłatwiej aplikacje pobrać z GitHub-a jako plik .zip i otworzyć w aplikacji Microsoft Visual Code

Sama aplikacja powinna załadować się sama i pojawi się panel logowania.

Jeżeli napotkamy problem, można skasować migrację i ją stworzyć na nowo za pomocą poleceń:

```bash
 Add-Migration
 Update-Database
```

##Łańcuch połaczenia z bazą

Całe połączenie opiera się na adresie:

```bash
 "Server=(localdb)\\mssqllocaldb;Database=HelpdeskDb;Trusted_Connection=True;TrustServerCertificate=True;"

```
Wykorzystałem `Microsoft Sql Managment Studio`


## Wytyczne projektu

#### Ocena aplikacji odbywa się na podstawie kodu źródłowego, który należy zamieścić na GitHub lub innym podobnym portalu.

Cała dokumentacja jest zawarta na portalu GitHub. A finalny kod, który przekazuje do oceny znajduję się w gałęzi `Master`

#### Repozytorium na GitHub musi być umieszczone co najmniej 3 tygodnie przez oddaniem projektu, i posiadać co najmniej 3 commity o różnych datach (nie wliczając pierwszego), świadczące o pracy nad projektem.

Repozytorium zamieściłem na platformie GitHub 27 stycznia 2023 i do dnia oddania projektu do głównej gałęzi `Master` trafiło 32 commitów.

#### Do każdego projektu należy przygotować dokumentację w postaci pliku README.md z opisem instalacji, wymagań, konfiguracji ( łańcuch połączenia z bazą, testowi użytkownicy i ich hasła, itd.) oraz opis działania aplikacji z punktu widzenia użytkownika (przykład opisu).

Całość jest zapisana w pliku README umieszczonym w repozytorium.

#### Punkty za projekt można uzyskać wyłącznie pod warunkiem, że aplikację projektu można uruchomić na podstawie kodu źródłowego. Projekty, których nie można uruchomić nie będą oceniane!  

Kod został sprawdzony na kilku komputerach w różnych konfiguracjach i powinien się uruchomić bez żadnych problemów z pomocą samego `Microsoft Visual Studio`, oraz profilaktycznie `Microsoft Sql Menagment Studio` w celu monitorowania zachowań bazy.

#### W skład każdej aplikacji powinny się znaleźć (wymagania minimalne na 35 punktów): min. 3 formularze, każdy z walidacją (5),

Formularz logowania m.in. nie dopuści do wysłania danych gdzie adres E-mail jest nie poprawny

Formularz do tworzenia złoszeń, który  m.in. nie pozwoli na wysłanie zgłoszenia bez uzupełnienia opisu.

Formularz do tworzenia użytkowników, który  m.in. nie pozwoli na wysłanie zgłoszenia z zduplikowanym adresem e-mail.

#### utrwalanie danych za pomocą EF z użyciem SQLite lub SQL Server, a aplikacja powinna zawierać co najmniej 4 encje, w tym trzy encje występujące w związkach (5),

Połaczenie bazy danych opiera sie na Sql Server, jeżeli w trakcie uruchomienia baza nie istnieje oraz jest pusta - to wypełni sie ona danymi.

Projekt posiada 4 Tabelę, które zostają zasilone łącznie czternastoma rekordami:

3x Użykownik

3x Urządzenia

5x Statusów

`3x zgłoszenia które są w momencie uruchomienia połaczone relacjami z innymi tabelami`

#### wykorzystanie DI i zastosowanie dwóch implementacji jednego interfejsu (np. implementacja repozytorium produkcyjnego i testowego) (5),

Projekt jest wyposażony w środowisko aplikacji internetowej oraz interfejsu testowego.


#### autoryzacja użytkowników - na poziomie podstawowym w postaci rozróżnienia zwykłych użytkowników (dostęp publiczny z logowaniem lub bez) i użytkowników uprzywilejowanych (np. administrator z dostępem po zalogowaniu) (5),

Logowanie sprawdza czy używkonik wpisał dane, które odpowiadają rekordowi w tabeli.

Rozróżnia czy `Bool IsAdmin = 1;` i w zależności od otrzymanej odpowiedzi odsyła do odpowieniego widoku.

W projekcie chciałem użyć technologii `Microsoft.entity.identity`, jednak na etapie już rozwiniętego projektu, sam program miał problem z poprawnym jego zastosowaniem.

W wyniku czego, logowanie opiera się na plikach Cookie, których kod nie pozwala na przejście do aplikacji z np. wysłanego od Kolegi linku czy z historii przegląrki. Kod generuję dostęp na czas 20 minut. 

Same testy polecam wykonywać z uwzględnianiem przycisku `Wyloguj` oraz kasowaniem plików Cookie

WebAPI REST odnoszące się do głównej encji (GET, POST, DELETE, PUT lub UPDATE) (5),

Utworzyłem WebAPI REST, które pozwala na operacje na głównej Encji `Tickets`.

Cały kod wraz z odpowienimi komentarzami znajduję się w lokalizacji;

``Project-Helpdesk_Portal-master\Controllers\apiController.cs``

#### testy jednostkowe najważniejszych funkcji i klas aplikacji (5),

Interfejs do testów tworzy bazę, wysyła do niej odpowiednią encję a następnie weryfikuję poprawność wybranych rekordów i ich wartości. Następnie ją kasuje.

Testy dzielą się na te którą mają wywołać wartość True oraz te które mają zwrócić wartość False.

#### wygląd i przejrzystość aplikacji zgodne z domyślnym stylem Bootstrap (5).

Uważam swoją pracę za miłą dla oka. Zastosowałem layout Bootstrapa, który łatwo dostrzec np. w przyciskach oraz w nawigacji strony.

---
#### projekt wyróżnia się ciekawymi funkcjami (wykraczającymi poza typowy CRUD) np. tworzenie rankingu popularności książek, wyszukiwanie książek wg kryteriów, stronicowanie, dynamiczne pobieranie danych potrzebnych do wstawienia w formularzu itd. (10).

Uważam, że mój projekt może pochwalić się zmieniającym się kolorem statusu w zależności od jego wartości oraz ukrytym hasłem z możliwością odkrycia (ikona oka), którą można zauważyć w szczegółach pojedyńczych użytkowników.
#### projekt wyróżnia się estetycznym i oryginalnym wyglądem (10), wykraczającym poza to, co oferuje domyślnie Bootstrap.

Projekt zawiera widoki oraz miejsca w, których użyty jest czysty kod `css` .
#### jakością kodu, który powinien być czytelny z jasno wydzielonymi warstwami np. serwis, osobne klasy modeli widoków itd.(15). 


Swój kod oceniam jako czytelny, występują w nim komentarze a sam layout folderów uważam za posortowany.
