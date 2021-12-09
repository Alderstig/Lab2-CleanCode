## Labb2

Denna labb är utförd av Philip Alderstig

- Jag började med att titta över projektet för att förstå dess funktion varpå jag lade mäske till vissa felstavningar samt variabelnamn som jag tyckte var otydliga.
  Jag rättade dessa stavfel som jag kunde hitta och satte nya variabelnamn som jag tyckte var mer passande och mer beskrivande.

- Jag bröt sedan ut vissa metoder (de som processade ordrar på olika sätt) i "OrderService" till egna klasser, med intentionen att använda Single responsibility principen.

- Jag skapade sedan ett interface som implementardes i mina nyskapade klasser samt för OrderService enligt Open/closed principen. Då samtliga klasser mer eller mindre skulle utföra liknande saker fast i olika fattningar implementerar de samma interface.
  Antagligen ommer man vid senare tillfälle behöva addera fler interface eller ändra på detta på något sätt om man skulle behöva utöka funktionaliteten eller göra klasspecifika metoder.

- Jag valde att inte göra några större förändringar i själva logiken just för att inte löpa risken att förstöra grundfunktionaliteten.

- Ett förbättringsområde hade kunnat vara att implementera Dependency inversion principen och dependency injection för att göra min "service" mindre beroende utav andra de andra klasserna.