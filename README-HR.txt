PUMP CALL OUT HUNTER PRO — WINDOWS 11 BUILD PROJECT

Ovo je projekt za izgradnju Windows .exe datoteke preko GitHub Actions. Nije gotova/kompajlirana EXE datoteka.

SADRŽAJ
- PumpCalloutHunterPRO.csproj: WinForms + WebView2 aplikacija.
- Program.cs: desktop prozor.
- src/index.html: lokalni scanner UI.
- .github/workflows/build-windows.yml: automatska izgradnja na GitHub Windows runneru.

KAKO IZGRADITI
1. Napravite NOVI GitHub repository, npr. pump-callout-hunter-pro.
2. Uploadajte sve datoteke i foldere iz ovog ZIP-a (uključujući .github).
3. Otvorite Actions i odaberite Build Windows EXE.
4. Kad build završi zeleno, otvorite workflow run i preuzmite artifact PumpCalloutHunterPRO-Windows11.
5. Raspakirajte artifact i pokrenite PumpCalloutHunterPRO.exe.

NAPOMENE
- Build zahtijeva internet na GitHub Actions runneru za NuGet pakete.
- Na računalu treba Microsoft Edge WebView2 Runtime. Windows 11 ga često već ima; ako ne, instalira se Microsoftov službeni runtime.
- Ovaj prvi build je funkcionalni prototip, ne auditiran trading signal. PumpDev i DexScreener su vanjski izvori; kvote i dostupnost se mogu mijenjati.
- Nema walleta, privatnih ključeva ni automatske kupnje.
- Ako repo koristi drugi naziv glavne grane, promijeniti branches u workflowu.
