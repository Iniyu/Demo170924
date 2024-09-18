# Demo Modus
## Aufgabe 1:
Erstelle einen neuen Herausgeber "Demo" mit dem Präfix "demo"
Erstelle eine neue Lösung "Demo" die alle Anpassungen enthält
Erstelle eine Modell-Driven App mit den Entitäten Firma, Kontakt

## Aufgabe 2:
Erstelle eine Webressource (vorzugsweise Entwicklung in Typescript) für die Tabelle Firma.
Erstelle über den neuen Command-Bar-Designer einen Befehl "Kontakte zählen" (der Button darf immer sichtbar sein)
Beim Klick auf den Button soll geprüft werden, wie viele Kontakte dieser Firma zugeordnet sind.
Während das Skript die Daten abruft und prüft, sollte ein "Bitte warten" Bildschirm erscheinen.
Hier wäre es wünschenswert, falls die Ermittlung schneller als 2 Sekunden geht, dass der "Bitte Warten"-Bildschirm erst nach 2 Sekunden verschwindet (um ein Flickern zu vermeiden). 
Die ermittelte Anzahl Kontakte soll in einem XRM-Alert-Dialog angezeigt werden
wenn kein Kontakte gefunden wurde: "Dieser Firma sind keine Kontakte zugeordnet."
bei mind. einem gefundenen Kontakt: "Der Firma sind x Kontakte zugeordnet."

## Aufgabe 3:
Erstellung eines Plugins auf Kontakt
Wird ein neuer Kontakt erstellt, sollen alle relevanten Adress1-Daten (Straße, PLZ, Ort, Land, ...) aus der übergeordneten Firma in den Kontakt übernommen werden.
Wird in einem bestehenden Kontakt die übergeordnete Firma geändert, sollen ebenfalls die Adress-Daten aus der neuen Firma übernommen werden.
Hinweis: Das Plugin soll möglichst nur laufen, wenn es auch etwas zu tun hat.

## Aufgabe 4: 
Alle Quellcodes in einem Github-Repo abspeichern, dann können wir uns das gerne gemeinsam anschauen.
