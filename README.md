Ćwiczenia 2 - Projekt obiektowy w C#

## Opis projektu
- Aplikacja konsolowa w C# udająca działanie uczelnianej wypożyczalni sprzętu.
System umożliwia zarządzanie sprzętem, użytkownikami oraz procesem wypożyczeń i zwrotów.

## Uruchomienie
- Sklonuj repo
- Otwórz projekt
- Zbuduj projekt
- Uruchom aplikację
Wymagania: .NET 10

## Domyślny czas wypożyczenia
- Domyślnie bezpłatne wypożyczenie sprzętu jest na max 14dni.
- Za każdy kolejny dzień spóźnienia ze wzrotem jest naliczana opłata 
administracyjna w wysokości 10zł brutto.

## Funkcjonalności
- Dodawanie nowego sprzętu typu laptop, 
projektorlub myszka komputerowa
- Dodawanie użytkowników typu student lub pracownik pracownik
- Wyświetlanie listy całego sprzętu
- Wyświetlanie sprzętu dostępnego do wypożyczenia
- Wypożyczanie sprzętu z uwzględnieniem limitów wypożyczeń - dla studenta max 2 wypożyczenia, dla pracownika max 5 wypożyczeń
- Zwrot sprzętu z automatycznym naliczaniem kar
- Usuwanie sprzętu - usunięte sprzętu z listy dostępnego i dodanie na listę sprzętu do utylizacji
- Usuwanie użytkowników
- Wyświetlanie aktywnych wypożyczeń użytkownika
- Raport podsumowujący stan wypożyczalni

## Scenariusz testowy:
- Aplikacja została przetestowana w praktyce - uruchamiamy ją 
i patrzymy czy wszystko działa tak jak powinno. W pliku 
Program.cs mamy rozpisany cały scenariusz: najpierw dodajemy
użytkowników (studentów i pracowników) oraz różny sprzęt (
laptopy, projektory, myszki). Później sprawdzamy czy 
limity działają - student może wypożyczyć maksymalnie 2 
rzeczy, a pracownik 5. Testujemy też zwroty - jedni oddają
w terminie (bez kary), inni się spóźniają i płacą 10 zł za
każdy dzień. Sprawdzamy też czy system nie daje się oszukać 
nie pozwala wypożyczyć czegoś czego nie ma, nie da się
usunąć wypożyczonego sprzętu, a przekroczenie limitu
kończy się komunikatem błędu. Na koniec generujemy 
raport i widzimy czy wszystko się zgadza.
