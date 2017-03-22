/****** Object:  Table [dbo].[T_SBF_Binnen]    Script Date: 03/22/2017 14:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_SBF_Binnen](
	[P_Id] [int] NOT NULL,
	[Frage] [varchar](500) NULL,
	[Antwort1] [varchar](500) NULL,
	[Antwort2] [varchar](500) NULL,
	[Antwort3] [varchar](500) NULL,
	[Antwort4] [varchar](500) NULL,
	[RichtigeAntwort] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[P_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[T_Fragenbogen_Thema]    Script Date: 03/22/2017 14:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Fragenbogen_Thema](
	[FragebogenNr] [int] NOT NULL,
	[Thema] [nchar](20) NOT NULL,
	[Beschreib] [nchar](100) NULL,
 CONSTRAINT [PK_T_FRAGENBOGEN_THEMA] PRIMARY KEY CLUSTERED 
(
	[FragebogenNr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[T_Fragebogen_unter_Maschine]    Script Date: 03/22/2017 14:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Fragebogen_unter_Maschine](
	[FragebogenNr] [int] NOT NULL,
	[F_Id_SBF_Binnen] [int] NOT NULL
) ON [PRIMARY]
GO


/****** Object:  ForeignKey [FK__T_Fragebo__F_Id___060DEAE8]    Script Date: 03/22/2017 14:38:55 ******/
ALTER TABLE [dbo].[T_Fragebogen_unter_Maschine]  WITH CHECK ADD FOREIGN KEY([F_Id_SBF_Binnen])
REFERENCES [dbo].[T_SBF_Binnen] ([P_Id])
GO





INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (1, N'Was ist zu tun, wenn vor Antritt der Fahrt nicht feststeht, wer Fahrzeugführer ist?', N'Der verantwortliche Fahrzeugführer muss bestimmt werden.', N'Ein Inhaber des Sportbootführerscheins muss die Fahrzeugführung übernehmen.', N'Der verantwortliche Fahrzeugführer muss gewählt werden.', N'Ein Inhaber des Sportbootführerscheins übernimmt die Verantwortung.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (2, N'In welchen Fällen darf weder ein Sportboot geführt noch dessen Kurs oder Geschwindigkeit selbstständig bestimmt werden?', N'Wenn man infolge körperlicher oder geistiger Mängel oder infolge des Genusses alkoholischer Getränke oder anderer berauschender Mittel in der sicheren Führung behindert ist oder wenn eine Blutalkoholkonzentration von 0,3 ‰ oder mehr im Körper vorhanden ist.', N'Wenn man infolge körperlicher oder geistiger Mängel oder infolge des Genusses alkoholischer Getränke oder anderer berauschender Mittel in der sicheren Führung behindert ist oder wenn eine Blutalkoholkonzentration von 0,5 ‰ oder mehr im Körper vorhanden ist.', N'Wenn man infolge körperlicher oder geistiger Mängel oder infolge des Genusses alkoholischer Getränke oder anderer berauschender Mittel in der sicheren Führung behindert ist oder wenn eine Blutalkoholkonzentration von 0,8 ‰ oder mehr im Körper vorhanden ist.', N'Wenn man infolge körperlicher oder geistiger Mängel oder infolge des Genusses alkoholischer Getränke oder anderer berauschender Mittel in der sicheren Führung behindert ist oder wenn eine Blutalkoholkonzentration von 1,0 ‰ oder mehr im Körper vorhanden ist.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (3, N'Wann ist ein Fahrzeug in Fahrt?', N'Wenn es weder an Land festgemacht ist noch vor Anker liegt noch Fahrt durchs Wasser macht.', N'Wenn es weder auf Grund sitzt noch vor Anker liegt noch manövrierbehindert oder manövrierunfähig ist.', N'Wenn es weder vor Anker liegt noch an Land festgemacht ist noch auf Grund sitzt.', N'Wenn es weder vor Anker liegt noch an Land festgemacht ist noch Fahrt über Grund macht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (4, N'Wie lang ist die Dauer eines kurzen Tons (•)?', N'Weniger als 1 Sekunde.', N'Etwa 2 Sekunden.', N'Etwa 1 Sekunde.', N'Weniger als 4 Sekunden.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (5, N'Wie lang ist die Dauer eines langen Tons (—)?', N'Etwa 2 - 6 Sekunden.', N'Etwa 1 - 2 Sekunden.', N'Etwa 6 - 8 Sekunden.', N'Etwa 4 - 6 Sekunden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (6, N'Wann gilt ein Fahrzeug unter Segel als Maschinenfahrzeug?', N'Wenn es durch das Segeln keine Fahrt durchs Wasser macht.', N'Wenn es mit einer Antriebsmaschine ausgerüstet ist.', N'Wenn es gleichzeitig mit Maschinenkraft fährt.', N'Wenn es durch das Segeln keine Fahrt über Grund macht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (7, N'Welches Signal führt ein Fahrzeug unter Segel, das als Maschinenfahrzeug gilt, zusätzlich am Tage?', N'Einen schwarzen Kegel, Spitze oben.', N'Zwei schwarze Bälle senkrecht übereinander.', N'Einen schwarzen Kegel, Spitze unten.', N'Einen schwarzen Rhombus.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (8, N'Welche Seite wird als Luvseite bezeichnet?', N'Die Seite in Fahrtrichtung links.', N'Die dem Wind abgewandte Seite.', N'Die Seite in Fahrtrichtung rechts.', N'Die dem Wind zugekehrte Seite.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (9, N'Welche Seite wird als Leeseite bezeichnet?', N'Die dem Wind zugekehrte Seite.', N'Die Seite in Fahrtrichtung rechts.', N'Die Seite in Fahrtrichtung links.', N'Die dem Wind abgewandte Seite.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (10, N'Wann müssen die Lichter von Fahrzeugen geführt oder gezeigt werden?', N'Bei Dunkelheit, schlechtem Wetter und verminderter Sicht.', N'Von Sonnenuntergang bis Sonnenaufgang und bei verminderter Sicht.', N'Von Sonnenaufgang bis Sonnenuntergang und bei verminderter Sicht.', N'Von abends 18 Uhr bis morgens 06 Uhr und bei verminderter Sicht.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (11, N'Wozu dient die Lichterführung?', N'Sie zeigt Fahrtrichtung und Kurs eines Fahrzeugs an.', N'Sie zeigt Fahrtrichtung und Position eines Fahrzeugs an.', N'Sie zeigt Fahrtrichtung und Lage eines Fahrzeugs an.', N'Sie zeigt Kurs und Geschwindigkeit eines Fahrzeugs an.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (12, N'Was für eine Laterne kann ein Segelfahrzeug von weniger als 20 m Länge anstelle der Seitenlichter und des Hecklichtes führen?', N'Eine Zweifarbenlaterne an gut sichtbarer Stelle.', N'Eine Dreifarbenlaterne an gut sichtbarer Stelle.', N'Eine Zweifarbenlaterne an oder nahe der Mastspitze.', N'Eine Dreifarbenlaterne an oder nahe der Mastspitze.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (13, N'Welche Lichter muss ein Fahrzeug unter Segel, das gleichzeitig mit Maschinenkraft fährt, führen? ', N'Die für ein Segelfahrzeug vorgeschriebenen Lichter.', N'Die für ein Maschinenfahrzeug vorgeschriebenen Lichter.', N'Zwei rote Rundumlichter senkrecht übereinander.', N'Seitenlichter rot und grün und ein rotes Rundumlicht.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (14, N'Wie weichen zwei Motorboote aus, die sich auf entgegengesetzten Kursen nähern?', N'Es muss das leewärtige Fahrzeug dem luvwärtigen Fahrzeug ausweichen.', N'Jedes Fahrzeug muss seinen Kurs nach Backbord ändern.', N'Jedes Fahrzeug muss seinen Kurs nach Steuerbord ändern.', N'Es muss das luvwärtige Fahrzeug dem leewärtigen Fahrzeug ausweichen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (15, N'Zwei Motorboote nähern sich auf kreuzenden Kursen. Es besteht die Gefahr eines Zusammenstoßes. Wer ist ausweichpflichtig?', N'Es muss das luvwärtige Fahrzeug dem leewärtigen Fahrzeug ausweichen.', N'Es muss das leewärtige Fahrzeug dem luvwärtigen Fahrzeug ausweichen.', N'Dasjenige Fahrzeug muss ausweichen, welches das Andere an seiner Steuerbordseite hat.', N'Dasjenige Fahrzeug muss ausweichen, welches das Andere an seiner Backbordseite hat.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (16, N'Welche Bedeutung hat folgendes Schallsignal: (• — • — • — • — • —)', N'Bleib-weg-Signal, Gefahrenbereich sofort verlassen.', N'Allgemeines Gefahr- und Warnsignal.', N'Ankerlieger über 100 m Länge.', N'Manövrierbehinderter Schleppverband über 200 m Länge.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (17, N'Welche Bedeutung hat folgendes Tafelzeichen?  {Binnen17.gif}', N'Begegnungsverbot.', N'Begegnungsverbot für Fahrzeuge über 20 m Länge.', N'Überholverbot für Fahrzeuge unter 20 m Länge.', N'Überholverbot.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (18, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen18.gif} ', N'Überholverbot; mit Gegenverkehr muss gerechnet werden.', N'Begegnungsverbot für Fahrzeuge über 12 m Länge.', N'Begegnungsverbot an einer Engstelle.', N'Überholverbot für alle Fahrzeuge.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (19, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen19.gif}', N'Wasserstraße, die jederzeit sicher befahren werden kann; keine Gefahr durch Seegang.', N'Gefährdeter Strandbereich, Überspülungsgefahr; Mindestpassierabstand 100 m.', N'Wasserstraße, die nicht jederzeit sicher befahren werden kann; Gefahr durch Seegang.', N'Sog und Wellenschlag vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (20, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen20.gif}', N'Maximalgeschwindigkeit in km/h, die auf der in Fahrtrichtung rechten Fahrwasserseite nicht überschritten werden darf.', N'Mindestabstand in Metern, der in der nachfolgenden Strecke vom Aufstellungsort der Tafel an eingehalten werden muss.', N'Maximalabstand in Metern, der in der nachfolgenden Strecke vom Aufstellungsort der Tafel an eingehalten werden muss.', N'Verengung des Fahrwassers auf 40 m.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (21, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen21.gif}', N'Weiterfahrt für Sportfahrzeuge verboten.', N'Dauernde Sperrung einer Teilstrecke der Wasserstraße.', N'Haltegebot vor beweglichen Brücken, Sperrwerken und Schleusen.', N'Gebot zur Abgabe eines langen Signaltons.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (22, N'Welche Bedeutung hat folgendes Tafelzeichen?  {Binnen22.gif}', N'Ankern verboten für alle Fahrzeuge.', N'Ankern verboten für Kleinfahrzeuge ab 12 m Länge.', N'Ankern verboten für Kleinfahrzeuge unter 12 m Länge.', N'Ankern und Festmachen verboten.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (23, N'Welche Bedeutung haben folgende Tafelzeichen? {Binnen23.gif}', N'Festmache- und Liegeverbot für gewerbliche Schiffe.', N'Festmache- und Liegeverbot.', N'Festmache- und Liegeverbot für Sportboote über 12 m Länge.', N'Festmache- und Liegeverbot für Sportboote.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (24, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen4.gif}', N'Abgabe eines kurzen Tons.', N'Abgabe eines kurzen und eines langen Tons.', N'Abgabe eines langen Tons.', N'Abgabe von zwei langen Tönen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (25, N'Welche Bedeutung haben folgende Tafelzeichen? {Binnen25.gif}', N'Fahren mit Wasserski oder Wassermotorrädern erlaubt. Wasserskiläufer und Wassermotorräder haben Vorfahrt.', N'Genehmigungspflichtige Übungsstrecke für das Fahren mit Wasserski oder Wassermotorrädern.', N'Genehmigungsfreie Übungsstrecke für das Fahren mit Wasserski oder Wassermotorrädern.', N'Wasserflächen, auf denen mit Wasserski oder Wassermotorrädern gefahren werden darf.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (26, N'Welche Bedeutung hat folgendes Tafelzeichen?  {Binnen26.gif}', N'Queren des Fahrwassers ist gestattet.', N'Wechseln der Fahrwasserseite ist gestattet.', N'Ende einer Gebots- oder Verbotsstrecke.', N'Streckenabschnitt für eine nicht frei fahrende Fähre.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (27, N'Welche Bedeutung hat folgendes Tafelzeichen? {Binnen27.gif}', N'Verbot der Durchfahrt, jedoch für Kleinfahrzeuge ohne laufende Antriebsmaschine befahrbar.', N'Verbot der Durchfahrt, jedoch für Kleinfahrzeuge ohne Antriebsmaschine befahrbar.', N'Verbot der Durchfahrt und Sperrung für Kleinfahrzeuge.', N'Verbot der Durchfahrt und Sperrung der Schifffahrt.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (28, N'Welche Bedeutung haben folgende Schifffahrtszeichen? {Binnen28.gif}', N'Stoppsignal für alle Fahrzeuge.', N'Brücke, Sperrwerk oder Schleuse geschlossen.', N'Außergewöhnliche Schifffahrtsbehinderung.', N'Anlage dauerhaft gesperrt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (29, N'Welche Bedeutung haben folgende Schifffahrtszeichen?  {Binnen29.gif}', N'Brücke, Sperrwerk oder Schleuse geschlossen.', N'Anlage dauerhaft gesperrt.', N'Außergewöhnliche Schifffahrtsbehinderung.', N'Stoppsignal für alle Fahrzeuge.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (30, N'Was bedeuten diese Lichter vor einer Schleuse?  {Binnen30.gif}', N'Schleuse in Betrieb, auf Ausfahrtsignal gemäß Reihenfolge warten.', N'Einfahrt frei, Gegenverkehr gesperrt.', N'Schleuse in Betrieb, auf Einfahrtsignal gemäß Reihenfolge warten.', N'Einfahrt frei, Schleusentor öffnet.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (31, N'Welches Merkblatt enthält Hinweise für das Verhalten zum Schutz seltener Tiere und Pflanzen sowie zur Reinhaltung der Gewässer?', N'Die 15 goldenen Regeln für Wassersportler.', N'Die 10 Grundregeln für Wassersportler.', N'Die 15 Verhaltensregeln für Wassersportler.', N'Die 10 goldenen Regeln für Wassersportler.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (32, N'Wie kann mitgeholfen werden, die Lebensmöglichkeiten der Pflanzen- und Tierwelt in Gewässern und Feuchtgebieten zu bewahren und zu fördern?', N'Durch umweltbewusstes Verhalten und Beachtung der ?Zehn Grundregeln für den Wassersport?', N'Durch vorausschauendes Fahren und Ausweichen entsprechend der Verkehrsvorschriften.', N'Durch umsichtiges Verhalten und Beachtung der Verkehrsvorschriften.', N'Durch umweltbewusstes Verhalten und Beachtung der ?Zehn goldenen Regeln für das Verhalten von Wassersportlern in der Natur?', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (33, N'Warum sollte man sich von Schilf- und Röhrichtzonen sowie von dicht bewachsenen Uferzonen möglichst weit fernhalten?', N'Weil durch die Pflanzen der Propeller blockiert werden könnte.', N'Weil in diesen Zonen badende Personen schwer zu erkennen sind.', N'Weil diese Zonen vielfach Rast- und Brutplätze besonders schutzwürdiger Vögel oder Fischlaichplätze sind.', N'Weil in diesen Zonen die Gefahr von Grundberührungen besteht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (34, N'Warum soll ein kleines Fahrzeug nicht dicht an ein großes in Fahrt befindliches Fahrzeug heranfahren?', N'Dichtes Heranfahren ist ein Verstoß gegen die Grundregeln für das Verhalten im Verkehr.', N'Da es dem großen in Fahrt befindlichen Fahrzeug sonst nicht ausweichen kann.', N'Es kann durch dessen Bug- oder Heckwelle kentern oder durch den Sog mit dem Fahrzeug kollidieren.', N'Es kann durch dessen Bug- oder Heckwelle Seeschlag erleiden.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (35, N'Warum soll man möglichst gegen Strom und Wind anlegen?', N'Weil sich das Fahrzeug dabei sicherer manövrieren lässt.', N'Weil dadurch Sog und Wellenschlag vermieden wird.', N'Weil dies die Steuerwirkung der Schraube erhöht.', N'Weil dadurch Einflüsse von Wellen und Wassertiefe ausgeglichen werden.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (36, N'Wie verhält man sich beim Begegnen mit anderen Fahrzeugen in einem engen Fahrwasser?', N'Geschwindigkeit erhöhen, um das Begegnungsmanöver zügig durchzuführen.', N'Das mit dem Strom fahrende Fahrzeug hat aufzustoppen.', N'Das gegen den Strom fahrende Fahrzeug ist ausweichpflichtig.', N'Geschwindigkeit herabsetzen und ausreichenden Passierabstand halten.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (37, N'Welche Gefahren können entstehen, wenn ein kleines von einem größeren Fahrzeug überholt wird?', N'Das kleinere Fahrzeug kann durch Stau, Sog oder Schwell aus dem Kurs laufen und kollidieren oder kentern, in flachen Gewässern extrem versetzt werden.', N'Das kleinere Fahrzeug kann durch Stau, Sog oder Schwell aus dem Kurs laufen und kollidieren oder querschlagen, in flachen Gewässern auf Grund laufen.', N'Das größere Fahrzeug kann durch Stau, Sog oder Schwell aus dem Kurs laufen und kollidieren oder querschlagen, in flachen Gewässern auf Grund laufen.', N'Das größere Fahrzeug kann durch Wellenbildung aus dem Kurs laufen und kollidieren oder querschlagen, in flachen Gewässern auf Grund laufen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (38, N'Wie viel Ankerkette bzw. -leine soll man unter günstigen Verhältnissen beim Ankern an einem geschützten Ankerplatz ausstecken? ', N'Mindestens die dreifache Wassertiefe bei Kette oder die fünffache bei Leine.', N'Mindestens die vierfache Wassertiefe bei Kette oder die fünffache bei Leine.', N'Mindestens die fünffache Wassertiefe bei Kette oder die dreifache bei Leine.', N'Mindestens die dreifache Wassertiefe bei Kette oder die vierfache bei Leine.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (39, N'Woran kann man erkennen, ob der Anker hält?', N'Wenn beim Handauflegen auf die Ankerkette oder -leine kein Rucken zu verspüren ist und sich die Ankerpeilung nicht ändert.', N'Wenn Ankerkette oder -leine nicht vibrieren und sich der anliegende Magnetkompasskurs nicht verändert.', N'Wenn beim Handauflegen auf die Ankerkette oder -leine kein Rucken zu verspüren ist und das Fahrzeug nicht schwojt.', N'Wenn beim Handauflegen auf die Ankerkette oder -leine kein Rucken zu verspüren ist und sich die Ankerpeilung ändert.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (40, N'Welches ist der günstigste Anlaufwinkel beim Anlegen?', N'Ein Winkel von 90° bis 100°.', N'Ein möglichst stumpfer Winkel.', N'Ein Winkel von 60° bis 70°.', N'Ein möglichst spitzer Winkel.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (41, N'Wie verhält sich im Allgemeinen das Schiff im Rückwärtsgang bei einem rechtsdrehenden Propeller?', N'Der Kurs des Schiffes ändert sich nicht.', N'Das Heck dreht nach Backbord.', N'Der Bug dreht nach Backbord.', N'Das Heck dreht nach Steuerbord.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (42, N'Was bewirkt der Quickstopp?', N'Automatisches Anlassen des Motors.', N'Kurze Unterbrechung des Motorlaufs.', N'Automatische Schubumkehr.', N'Unterbrechung von Zündkontakt bzw. Kraftstoffzufuhr.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (43, N'Was ist zu unternehmen, wenn Treibstoff oder Öl in die Bilge gelangt?', N'Mit entsprechendem Mittel neutralisieren.', N'Gleichmäßig verteilen.', N'Mit Lappen aufnehmen und umweltgerecht entsorgen.', N'Räume lüften und abwarten.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (44, N'Was ist unter einem rechtsdrehenden Propeller zu verstehen?', N'Von achtern gesehen in Vorausfahrt Drehung des Propellers gegen den Uhrzeigersinn.', N'Von achtern gesehen in Vorausfahrt Drehung des Propellers im Uhrzeigersinn.', N'Von vorne gesehen in Rückwärtsfahrt Drehung des Propellers gegen den Uhrzeigersinn.', N'Von vorne gesehen in Vorausfahrt Drehung des Propellers im Uhrzeigersinn.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (45, N'Was ist unter einem linksdrehenden Propeller zu verstehen? ', N'Von achtern gesehen in Vorausfahrt Drehung des Propellers im Uhrzeigersinn.', N'Von vorne gesehen in Rückwärtsfahrt Drehung des Propellers im Uhrzeigersinn.', N'Von achtern gesehen in Vorausfahrt Drehung des Propellers gegen den Uhrzeigersinn.', N'Von vorne gesehen in Vorausfahrt Drehung des Propellers gegen den Uhrzeigersinn.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (46, N'Was ist unter der indirekten Ruderwirkung (Radeffekt) des Propellers zu verstehen?', N'Das Versetzen nach vorne.', N'Das Versetzen nach hinten.', N'Das seitliche Versetzen des Hecks.', N'Das seitliche Versetzen des Bugs.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (47, N'Weshalb ist die Kenntnis der Propellerdrehrichtung von Bedeutung?', N'Sie hilft beim Kurshalten.', N'Sie hilft beim Manövrieren.', N'Sie hilft beim Überholen.', N'Sie hilft beim Begegnen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (48, N'Welche Anlegeseite ist mit rechtsdrehendem Propeller empfehlenswert und warum?', N'Die Steuerbord- oder Backbordseite je nach Ruderlage.', N'Die Backbordseite ? der Radeffekt zieht das Fahrzeug an die Pier.', N'Es gibt keine empfehlenswerte Anlegeseite.', N'Die Steuerbordseite ? der Radeffekt zieht das Fahrzeug an die Pier.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (49, N'Was muss beim Tanken beachtet werden?', N'Motor in Leerlaufstellung, keine elektrischen Schalter betätigen, Vorbereitung gegen das Überlaufen von Kraftstoff treffen, kein offenes Feuer.', N'Motor abstellen, Feuerlöscher bereithalten, Vorbereitung gegen das Überlaufen von Kraftstoff treffen, kein offenes Feuer.', N'Fenster schließen, keine elektrischen Schalter betätigen, Vorbereitung gegen das Überlaufen von Kraftstoff treffen, kein offenes Feuer.', N'Motor abstellen, keine elektrischen Schalter betätigen, Vorbereitung gegen das Überlaufen von Kraftstoff treffen, kein offenes Feuer.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (50, N'Wodurch wird bei einem Fahrzeug mit Außenbordmotor und ohne Ruderanlage die Ruderwirkung erzielt?', N'Durch Schraubenstrom und Anstellwinkel des Propellers.', N'Durch den Schraubenwiderstand und Anstellwinkel des Propellers.', N'Durch den Schraubenwiderstand und Richtung des Propellers.', N'Durch Schraubenstrom und Richtung des Propellers.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (51, N'Weshalb setzt bei einem Fahrzeug mit Einbaumaschine und starrer Welle bei Aufnahme der Rückwärtsfahrt die Ruderwirkung erst relativ spät ein? ', N'Weil sich durch den Radeffekt ein Unterdruck am Propeller entwickelt.', N'Durch den Abstand von Propeller und Ruderblatt.', N'Weil sie erst mit Anströmung des Ruderblattes einsetzt.', N'Weil sich durch den Radeffekt ein Unterdruck am Ruder entwickelt.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (52, N'Während der Fahrt sollte die Maschinenanlage ständig überwacht werden. Worauf muss besonders geachtet werden?', N'Schraubendrehzahl, Getriebeöltemperatur, Öldruck.', N'Kühlwasseraustritt, Drehzahlmesser, Keilriemenspannung.', N'Motortemperatur, Öldruck, Ladekontrolle.', N'Druck der Einspritzpumpe, Impellerpumpe, Ölpumpe.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (53, N'Die Temperatur der Antriebsmaschine überschreitet die zulässigen Grenzwerte. Was könnte die mögliche Ursache sein?', N'Defektes Thermostat, defekte Impellerpumpe, geschlossenes Seeventil, zu niedriger Kühlwasserstand.', N'Zu viel Motoröl, defekte Impellerpumpe, geschlossenes Seeventil, zu niedriger Kühlwasserstand.', N'Defektes Thermostat, defekte Kupplung, geschlossenes Seeventil, zu niedriger Kühlwasserstand.', N'Defektes Thermostat, defekte Impellerpumpe, geschlossenes Seeventil, zu hohe Batteriespannung.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (54, N'Die Ladekontrolllampe erlischt nach dem Starten nicht. Was könnte die mögliche Ursache sein?', N'Anlasser ist nach dem Starten ausgefallen.', N'Lichtmaschine bzw. Regler der Lichtmaschine defekt.', N'Keilriemen gerissen und hoher Stromverbrauch.', N'Zu hohe Motordrehzahl.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (55, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (56, N'Der Motor ist gestartet worden. Was kann die Ursache sein, wenn nach dem Einkuppeln der Antriebswelle der Motor stehenbleibt?', N'Verschmutzter Luftfilter.', N'Blockierter Propeller.', N'Blockierte Kraftstoffzufuhr.', N'Verschmutzter Ölfilter.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (57, N'Ein Außenborder mit gefülltem Tank bleibt während der Fahrt stehen. Was könnten die Ursachen sein?', N'Ansaugdüsen zu groß bzw. zu klein.', N'Tankdeckel ist offen.', N'Schraube an der Welle lose.', N'Belüftungsschraube geschlossen; verstopfte Kraftstoffleitung.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (58, N'Was sollte stets getan werden, bevor nach Ende einer Fahrt der Außenborder hochgekippt oder abgenommen wird?', N'Kraftstoff auffüllen, wegen Tankkorrosion.', N'Quickstopp ziehen, wegen Verlust des Schlüssels.', N'Kraftstoffhahn offen lassen zur besseren Belüftung.', N'Vergaser leerfahren, damit kein Kraftstoff ausläuft.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (59, N'Welche Einstellung führt bei Bootsmotoren zu einem besonders hohen Schadstoffausstoß und sollte unbedingt vermieden werden?', N'Verringerter Luftanteil beim Luft-Kraftstoff-Gemisch; erhöhter Ölanteil beim Mischungsverhältnis bei Zweitaktmotoren.', N'Erhöhter Luftanteil beim Luft-Kraftstoff-Gemisch; verringerter Ölanteil beim Mischungsverhältnis bei Zweitaktmotoren.', N'Normales Luft-Kraftstoff-Gemisch; normales Mischungsverhältnis bei Zweitaktmotoren.', N'Erhöhter Luftanteil beim Luft-Kraftstoff-Gemisch; erhöhter Ölanteil beim Mischungsverhältnis bei Zweitaktmotoren.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (60, N'Welche Vorkehrungen sind für das längere Verlassen des Fahrzeugs zu treffen?', N'Alle Seeventile schließen und den Hauptschalter des Bordnetzes ausschalten.', N'Tagestank schließen und Kraftstofffilter entwässern.', N'Kraftstoff- und Wassertank auffüllen und das Bordnetz aufladen.', N'Fahrzeug seefest hinterlassen und den Hafenmeister verständigen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (61, N'Wie ist ein enges Gewässer zu befahren, wenn man sich am Ufer festgemachten Fahrzeugen nähert? ', N'Beibehaltung der Geschwindigkeit, um durch Gleitfahrt schädlichen Sog und Wellenschlag auszuschließen.', N'Verringerung der Geschwindigkeit und nötigenfalls vom Rechtsfahrgebot abweichen.', N'Auf Höhe der festgemachten Fahrzeuge aufstoppen und überprüfen, dass kein Dritter behindert oder geschädigt wird.', N'Verringerung der Geschwindigkeit, um schädlichen Sog und Wellenschlag zu vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (62, N'Wo sollen die Gasbehälter einer Flüssiggasanlage gelagert werden?', N'Möglichst auf dem Vorschiff, geschützt vor Sonneneinstrahlung, sonst in einem besonders abgeschlossenen Raum für Gasbehälter, der in Bodenhöhe eine Öffnung nach außenbords hat.', N'Möglichst an Deck, geschützt vor Sonneneinstrahlung, sonst in einem besonders abgeschlossenen Raum für Gasbehälter, der oben belüftet ist.', N'Möglichst an Deck, geschützt vor Sonneneinstrahlung, sonst in einem besonders abgeschlossenen Raum für Gasbehälter, der in Bodenhöhe eine Öffnung nach außenbords hat.', N'Möglichst unten im Schiff, geschützt vor Sonneneinstrahlung, sonst in einem besonders abgeschlossenen Raum für Gasbehälter, der in Bodenhöhe eine Öffnung nach außenbords hat.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (63, N'Warum sind die Flüssiggase Propan und Butan an Bord besonders gefährlich?', N'Beide Gase sind schwerer als Luft und bilden mit Wasser ein explosives Gemisch.', N'Beide Gase sind schwerer als Luft und bilden mit Luft ein explosives Gemisch.', N'Beide Gase sind leichter als Luft und bilden mit Luft ein explosives Gemisch.', N'Beide Gase sind schwerer als Wasser und bilden mit Wasser ein explosives Gemisch.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (64, N'Was ist zu tun, wenn Flüssiggas in das Innere des Bootes gelangt?', N'Gaszuführung absperren und für Lüftung sorgen. Außerdem keine elektrischen Schalter betätigen und per Telefon Hilfe holen.', N'Gasleitung entleeren und die Gasfreiheit mit dem Feuerzeug prüfen sowie über Funk oder Mobiltelefon Hilfe anfordern.', N'Gasleitung entleeren und für Lüftung sorgen. Außerdem keine elektrischen Schalter betätigen und keine Telefone benutzen.', N'Gaszuführung absperren und für Lüftung sorgen. Außerdem keine elektrischen Schalter betätigen und keinen Funk und keine Mobiltelefone benutzen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (65, N'Was ist vor Inbetriebnahme einer Flüssiggasanlage zu prüfen?', N'Die Abnahme der Anlage darf nicht länger als drei Jahre zurückliegen. Haupthahn und andere Absperrventile sind zu öffnen.', N'Die Anlage muss abgenommen sein und jährlich überprüft werden. Die Inbetriebnahme darf nur durch eine besonders geprüfte Person erfolgen.', N'Die Anlage muss abgenommen sein, die Inbetriebnahme darf nur durch eine besonders geprüfte Person erfolgen.', N'Die Anlage muss abgenommen sein, Leitungen und Anschlüsse müssen dicht sein. Haupthahn und andere Absperrventile sind zu öffnen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (66, N'Was ist zu beachten, wenn eine Flüssiggasanlage außer Betrieb gesetzt wird?', N'Der Flüssiggasbehälter ist vollständig zu entleeren.', N'Haupthahn und Absperrventile sind zu schließen.', N'Gasflasche fachgerecht entsorgen.', N'Die Anlage ist gasfrei zu machen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (67, N'Wie oft muss man aufblasbare Rettungsmittel warten lassen?', N'Jährlich und nach jedem Einsatz oder Übungsgebrauch.', N'Entsprechend der Herstellerangabe, mindestens alle 2 Jahre.', N'Jährlich, jeweils vor Beginn der Wassersportsaison.', N'Entsprechend der Herstellerangabe, mindestens alle 3 Jahre.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (68, N'Welcher Feuerlöscher ist für Sportboote zweckmäßig und wie oft muss man einen Feuerlöscher überprüfen lassen?', N'CO2-Feuerlöscher, mindestens alle zwei Jahre.', N'ABC-Pulverlöscher, mindestens einmal pro Jahr.', N'ABC-Pulver- und Schaumlöscher, mindestens alle 2 Jahre.', N'Feuerlöscher mit Löschschaum, mindestens einmal pro Jahr.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (69, N'Welche Maßnahmen muss man ergreifen, um einen Brand mit dem Feuerlöscher wirksam zu bekämpfen?', N'Luftzufuhr verhindern und den Feuerlöscher mit sparsamen Löschstrahlstößen einsetzen, dabei das Feuer möglichst von oben bekämpfen.', N'Handhabungshinweise durchlesen und den Feuerlöscher sofort einsetzen, dabei das Feuer möglichst von unten bekämpfen.', N'Rauchabzug sicherstellen und Feuerlöscher rechtzeitig einsetzen, dabei den Löschstrahl möglichst in die lodernden Flammen halten.', N'Luftzufuhr verhindern, Feuerlöscher erst am Brandherd einsetzen und das Feuer möglichst von unten bekämpfen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (70, N'Wie hat man sich nach einem Zusammenstoß zu verhalten?', N'Hilfe leisten und so lange am Unfallort bleiben, bis ein weiterer Beistand nicht mehr erforderlich ist; Verschlusszustand herstellen.', N'Hilfe leisten und so lange am Unfallort bleiben, bis ein weiterer Beistand nicht mehr erforderlich ist; die Wasserschutzpolizei benachrichtigen.', N'Hilfe leisten und so lange am Unfallort bleiben, bis ein weiterer Beistand nicht mehr erforderlich ist; Notsignal geben.', N'Hilfe leisten und so lange am Unfallort bleiben, bis ein weiterer Beistand nicht mehr erforderlich ist; alle erforderlichen Daten austauschen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (71, N'Welche Faktoren sind hauptsächlich für das Wettergeschehen, also für Wind und Niederschläge, ausschlaggebend?', N'Luftdruckänderung, Tageszeit und Temperatur.', N'Luftdruckänderung, Luftfeuchtigkeit und Temperatur.', N'Luftdruckänderung, Sonneneinstrahlung und Höhenlage.', N'Luftdruckänderung, Luftfeuchtigkeit und Jahreszeit.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (72, N'In welcher Situation dürfen Notsignale gegeben werden?', N'Wenn Gefahr für Leib oder Leben von Personen besteht und daher Hilfe benötigt wird.', N'Wenn Gefahr für Leib oder Leben von Personen oder erhebliche Sachwerte besteht und daher Hilfe benötigt wird.', N'Wenn Gefahr für Leib oder Leben von Personen besteht oder das Schiff nicht mehr sicher manövriert werden kann.', N'Wenn Gefahr für Leib oder Leben von Personen, erhebliche Sachwerte oder die maritime Umwelt besteht.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (73, N'Für welche Sportboote ist der Sportbootführerschein-Binnen vorgeschrieben?', N'Für Sportboote von mehr als 11,03 kW (15 PS) Nutzleistung und mehr als 15 m Länge.', N'Für Sportboote von mehr als 11,03 kW (15 PS) Nutzleistung, auf dem Rhein von mehr als 3,68 kW (5 PS) Nutzleistung, und weniger als 15 m Länge.', N'Für Sportboote von weniger als 11,03 kW (15 PS) Nutzleistung und mehr als 15 m Länge.', N'Für Sportboote von weniger als 11,03 kW (15 PS) Nutzleistung und weniger als 15 m Länge.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (74, N'Auf welchen Gewässern gilt der der Sportbootführerschein-Binnen?', N'Auf den Binnenschifffahrtsstraßen und allen Landesgewässern.', N'Auf allen Wasserstraßen im Binnenbereich.', N'Auf allen Landesgewässern.', N'Auf den Binnenschifffahrtsstraßen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (75, N'Aus welchen Gründen muss der Sportbootführerschein-Binnen entzogen werden?', N'Bei zweifelhafter Tauglichkeit wegen Alkoholmissbrauch.', N'Bei fehlender Tauglichkeit oder fehlender Zuverlässigkeit.', N'Bei fehlender Zuverlässigkeit wegen einer Ordnungswidrigkeit.', N'Bei zweifelhafter Zuverlässigkeit aus Altersgründen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (76, N'Was beinhaltet die allgemeine Sorgfaltspflicht?', N'Es ist alles zu tun, was zur Vermeidung von Beschädigungen an Fahrzeugen, Anlagen oder Ufern, Behinderung der Schifffahrt und Beeinträchtigung der Umwelt nötig ist.', N'Vermeidung der Gefährdung von Menschenleben, von Beschädigungen an Fahrzeugen, Anlagen oder Ufern, Behinderung der Schifffahrt und Beeinträchtigung der Umwelt.', N'Es ist alles zu tun, was zur Vermeidung der Gefährdung von Menschenleben, Behinderung der Schifffahrt und Beeinträchtigung der Umwelt nötig ist.', N'Gefährdung von Menschenleben, Beschädigungen an Fahrzeugen, Anlagen oder Ufern und Beeinträchtigung der Umwelt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (77, N'Unter welchen Umständen darf von den geltenden Bestimmungen über das Verhalten im Verkehr auf den Binnenschifffahrtsstraßen abgewichen werden?', N'Bei mittelbar drohender Gefahr für sich oder andere.', N'Bei unmittelbar bevorstehendem Überholvorgang.', N'Bei unmittelbar drohender Gefahr für sich oder andere.', N'Bei unmittelbar bevorstehender Begegnung.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (78, N'Welche Anforderungen neben der körperlichen und geistigen Tauglichkeit und fachlichen Eignung muss der Führer eines Sportbootes auf Binnenschifffahrtsstraßen, mit Ausnahme des Rheins, erfüllen, wenn die größte Nutzleistung der Antriebsmaschine 11,03 kW oder weniger beträgt?', N'Mindestalter 16 Jahre.', N'Besitz eines Sportbootführerscheins-Binnen oder eines gleichgestellten Befähigungszeugnisses.', N'Nachweis der Zuverlässigkeit.', N'Mindestalter 14 Jahre.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (79, N'Welche Anforderung neben der körperlichen und geistigen Tauglichkeit und fachlichen Eignung muss der Führer eines Sportbootes auf dem Rhein erfüllen, wenn die Nutzleistung der Antriebsmaschine mehr als 3,68 kW beträgt?', N'Nachweis der Zuverlässigkeit.', N'Mindestalter 16 Jahre.', N'Mindestens 14 Jahre.', N'Besitz eines Sportbootführerscheins-Binnen oder eines gleichgestellten Befähigungszeugnisses.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (80, N'Welche Anforderungen muss der Rudergänger eines Sportbootes mit Antriebsmaschine grundsätzlich auf den Binnenschifffahrtsstraßen erfüllen?', N'Er muss mindestens 18 Jahre alt und körperlich, geistig und fachlich geeignet sein.', N'Er muss mindestens 14 Jahre alt und körperlich, geistig und fachlich geeignet sein.', N'Er muss mindestens 16 Jahre alt und Inhaber des Sportbootführerschein- Binnen sein.', N'Er muss mindestens 16 Jahre alt und körperlich, geistig und fachlich geeignet sein.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (81, N'Wo erhält man Auskünfte über Verkehrsbeschränkungen und aktuelle Information über Binnenschifffahrtsstraßen?', N'In der Binnenschifffahrtsstraßenordnung Teil II.', N'Bei einem Wasserwirtschaftsamt und bei der Wasserschutzpolizei.', N'In der Binnenschiffsuntersuchungsordnung.', N'Bei der Wasser- und Schifffahrtsverwaltung, im Internet unter www.elwis.de und bei der Wasserschutzpolizei.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (82, N'Wozu muss der Rudergänger eines Sportbootes zur sicheren Steuerung in der Lage sein?', N'Alle Schallzeichen wahrnehmen zu können und nach allen Seiten genügend freie Sicht zu haben.', N'Alle Informationen und Weisungen zu empfangen und zu geben und nach allen Seiten genügend freie Sicht zu haben.', N'Alle Informationen und Weisungen zu empfangen und zu geben, alle Schallzeichen wahrzunehmen und nach allen Seiten genügend freie Sicht zu haben.', N'Alle Informationen und Weisungen zu empfangen und zu geben.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (83, N'Bis zu welcher Schiffslänge berechtigt der Sportbootführerschein- Binnen zum Führen eines Sportbootes auf Binnenschifffahrtsstraßen?', N'Bis zu einer Länge von weniger als 15 m (ohne Ruder und Bugspriet).', N'Bis zu einer Länge von weniger als 25 m (ohne Ruder und Bugspriet).', N'Bis zu einer Länge von weniger als 15 m (mit Ruder und Bugspriet).', N'Bis zu einer Länge von weniger als 25 m (mit Ruder und Bugspriet).', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (84, N'Wo findet man die allgemeinen Verkehrsregeln für die Binnenschifffahrtsstraßen und den Rhein? ', N'Wassermotorräderverordnung, Wasserskiverordnung.', N'Moselschifffahrtspolizeiverordnung, Donauschifffahrtspolizeiverordnung.', N'Binnenschiffsuntersuchungs-Ordnung, Rheinschifffahrtspolizeiverordnung.', N'Binnenschifffahrtsstraßen-Ordnung, Rheinschifffahrtspolizeiverordnung.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (85, N'Wo findet man die allgemeinen Verkehrsregeln für die Mosel und die Donau?', N'Donauschifffahrtspolizeiverordnung, Binnenschifffahrtsstraßen-Ordnung.', N'Wassermotorräderverordnung, Wasserskiverordnung.', N'Moselschifffahrtspolizeiverordnung, Donauschifffahrtspolizeiverordnung.', N'Moselschifffahrtspolizeiverordnung, Binnenschiffsuntersuchungs-Ordnung.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (86, N'Wo findet man Regeln für den Verkehr von Wassermotorrädern und für das Wasserskilaufen?', N'Moselschifffahrtspolizeiverordnung, Binnenschiffsuntersuchungs-Ordnung.', N'Binnenschifffahrtsstraßen-Ordnung, Rheinschifffahrtspolizeiverordnung.', N'Moselschifffahrtspolizeiverordnung, Donauschifffahrtspolizeiverordnung.', N'Wassermotorräderverordnung, Wasserskiverordnung.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (87, N'Welche Maßnahmen sind zu treffen, wenn das Fahrzeug innerhalb des Fahrwassers bzw. der Fahrrinne Grundberührung hat? ', N'Das Fahrzeug verbleibt vor Ort bis die Wasserschutzpolizei eintrifft.', N'Ein Baggerunternehmen ist zu verständigen, damit das Hindernis beseitigt wird.', N'ie Wasser- und Schifffahrtsverwaltung oder die Wasserschutzpolizei ist mit genauer Angabe der Hindernisstelle zu benachrichtigen.', N'Die Wasserschutzpolizei oder die Wasser- und Schifffahrtsverwaltung ist mit genauer Angabe der Schiffsdaten zu informieren.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (88, N'Was versteht man unter Fahrwasser?', N'Es ist der Teil der Wasserstraße, der durch die Ufer begrenzt ist.', N'Den Teil der Wasserstraße, der den örtlichen Umständen nach vom durchgehenden Schiffsverkehr benutzt wird.', N'Es ist der Teil der Wasserstraße, deren Tiefe bei 2,50 m und mehr beginnt.', N'Den Teil der Wasserstraße, in dem für den durchgehenden Schiffsverkehr bestimmte Breiten und Tiefen vorgehalten bzw. angestrebt werden.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (89, N' Was versteht man unter Fahrrinne?', N'Es ist der Teil der Wasserstraße, in dem für den durchgehenden Schiffsverkehr bestimmte Breiten und Tiefen vorgehalten bzw. angestrebt werden.', N'Den Teil der Wasserstraße, der den örtlichen Umständen nach vom durchgehenden Schiffsverkehr benutzt wird.', N'Es ist der Teil der Wasserstraße, deren Breite mindestens 88 m und deren Tiefe mindestens 2,50 m beträgt.', N'Es ist der Teil der Wasserstraße, deren Breite mindestens 150 m und deren Tiefe mindestens 3,00 m beträgt.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (90, N'Wie wird die Schifffahrt vom Erreichen bestimmter Wasserstände und Hochwassermarken informiert?', N'Durch Bekanntgaben der Hochwasserschutzzentrale.', N'Durch Aushang bei Hafenämtern und Schleusen.', N'Durch Nautischen Informationsfunk, Information im Rundfunk, im Fernsehen und im Internet.', N'Durch Aushang bei Wasserschutzpolizei-Stationen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (91, N'Wo kann der Sportbootfahrer vor Ort das Erreichen bestimmter Wasserstände und Hochwassermarken feststellen?', N'An den Aushängen bei Hafenämtern und Schleusen.', N'An den Pegeln und ausgewiesenen Hochwassermarken.', N'An den Pegeln und den Einsenkungsmarken der Fahrzeuge.', N'An den Aushängen bei Wasserschutzpolizei-Stationen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (92, N'Welche Auswirkungen kann das Erreichen der Hochwassermarke I für die Sportschifffahrt haben? ', N'Geschwindigkeitsbeschränkung und Fahrverbot für Fahrzeuge ohne Sprechfunk.', N'Einstellung der Schifffahrt.', N'Überholverbot und Fahrverbot für Fahrzeuge ohne Sprechfunk.', N'Verbot der Schifffahrt bei Nacht und unsichtigem Wetter.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (93, N'Welche Auswirkungen hat das Erreichen der Hochwassermarke II für die Sportschifffahrt?', N'Überholverbot und Fahrverbot für Fahrzeuge ohne Sprechfunk.', N'Einstellung der Schifffahrt.', N'Verbot der Schifffahrt bei Nacht und unsichtigem Wetter.', N'Geschwindigkeitsbeschränkung und Fahrverbot für Fahrzeuge ohne Sprechfunk.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (94, N'In welche Richtung werden bei Flüssen die Uferseiten als rechtes bzw. linkes Ufer bezeichnet?', N'Von der Quelle bis zur Mündung.', N'Bei der Talfahrt liegt die rechte Uferseite links.', N'Von der Mündung bis zur Quelle.', N'Bei der Bergfahrt liegt die rechte Uferseite rechts.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (95, N'Was bedeutet "zu Berg" oder "Bergfahrt" auf Flüssen?', N'Die Fahrt in Richtung Mündung.', N'Die Fahrt in Richtung Quelle.', N'Die Fahrt mit der Strömung.', N'Die Fahrt über Grund.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (96, N'Was bedeutet "zu Berg" oder "Bergfahrt" auf Kanälen?', N'Die Fahrt in Richtung Quelle.', N'Die Fahrt, die in Teil II der Binnenschifffahrtsstraßen-Ordnung als Fahrt ?zu Berg? oder ?Bergfahrt? festgelegt ist.', N'Die Fahrt gegen die Strömung.', N'Die Fahrt, die in Teil I der Binnenschifffahrtsstraßen-Ordnung als Fahrt ?zu Berg? oder ?Bergfahrt? festgelegt ist.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (97, N'Welche Zeichen begrenzen die Fahrrinne zum rechten Ufer?', N'Rote Spierentonnen oder Schwimmstangen.', N'Rote Stumpftonnen oder Schwimmstangen.', N'Grüne Spierentonnen oder Schwimmstangen.', N'Grüne Spitztonnen oder Schwimmstangen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (98, N'Welche Zeichen begrenzen die Fahrrinne zum linken Ufer?', N'Rote Stumpftonnen oder Schwimmstangen.', N'Rote Spierentonnen oder Schwimmstangen.', N'Grüne Spierentonnen oder Schwimmstangen.', N'Grüne Spitztonnen oder Schwimmstangen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (99, N'Welche Fahrrinnenseite hat ein Bergfahrer an seiner Steuerbordseite und wie ist diese gekennzeichnet?', N'Die linke Fahrrinnenseite, gekennzeichnet durch grüne Spitztonnen oder Schwimmstangen.', N'Die linke Fahrrinnenseite, gekennzeichnet durch rote Stumpftonnen oder Schwimmstangen.', N'Die rechte Fahrrinnenseite, gekennzeichnet durch rote Stumpftonnen oder Schwimmstangen.', N'Die rechte Fahrrinnenseite, gekennzeichnet durch grüne Spitztonnen oder Schwimmstangen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (100, N'Was bedeutet eine rot-grün gestreifte Tonne oder Schwimmstange und was ist zu beachten? ', N'Fahrrinnenspaltung. Vorbeifahrt nur an Steuerbord möglich.', N'Fahrrinnenspaltung. Vorbeifahrt an beiden Seiten möglich.', N'Fahrrinnenspaltung. In Fahrtrichtung rechts halten.', N'Fahrrinnenspaltung. In Fahrtrichtung links halten.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (101, N'Mit welchen Zeichen werden Hindernisse wie zum Beispiel Buhnen und Kribben an der rechten Seite der Wasserstraße bezeichnet?', N'Stangen mit Toppzeichen: grüner Kegel, Spitze nach unten, oder grünweiß gestreifte Schwimmstange mit grünem Kegel.', N'Stangen mit Toppzeichen: grüner Kegel, Spitze nach oben, oder grünweiß gestreifte Schwimmstange mit grünem Kegel.', N'Stangen mit Toppzeichen: roter Kegel, Spitze nach oben, oder rot-weiß gestreifte Schwimmstange mit rotem Zylinder.', N'Stangen mit Toppzeichen: roter Kegel, Spitze nach unten, oder rot-weiß gestreifte Schwimmstange mit rotem Zylinder.', 4)
GO
print 'Processed 100 total records'
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (102, N'Was kennzeichnet eine grün-weiß gestreifte Schwimmstange mit grünem Kegel, Spitze nach oben, oder eine grüne Tonne mit grünweiß gestreiftem Aufsatz mit grünem Kegel, Spitze nach oben?', N'Fahrrinnenrand an der linken Seite der Wasserstraße.', N'Fahrrinnenrand an der rechten Seite der Wasserstraße.', N'Hindernis an der linken Seite der Wasserstraße.', N'Hindernis an der rechten Seite der Wasserstraße.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (103, N'Was ist in Kanälen verboten?', N'Begegnen.', N'Wenden.', N'Ankern.', N'Überholen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (104, N'Was bedeuten auf einem stillliegenden Fahrzeug zwei weiße Lichter übereinander?', N'Ein Ankerlieger, der zwei Anker ausgelegt hat.', N'Ein Ankerlieger, dessen Anker die Schifffahrt gefährden kann.', N'Ein stillliegender Schubverband.', N'Ein Fahrzeug über 135 m.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (105, N'Welches Licht setzt ein stillliegendes Fahrzeug?', N'Ein weißes Topplicht und ein weißes Hecklicht.', N'Ein von allen Seiten sichtbares weißes Rundumlicht auf der Fahrwasserseite.', N'Ein von allen Seiten sichtbares weißes Blinklicht auf der Fahrwasserseite.', N'Die Seitenlichter und ein sichtbares weißes Rundumlicht.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (106, N' Wie sind Anker am Tage bezeichnet, die die Schifffahrt behindern können?', N'Mit einem gelben Döpper.', N'Mit einem roten Döpper.', N'Mit einem grünen Döpper.', N'Mit einem gelben Döpper.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (107, N'Was bedeutet dieses Tafelzeichen? {Binnen107.gif}', N'Liegestelle für Fahrzeuge mit brennbaren Stoffen, für Kleinfahrzeuge verboten.', N'Liegestelle für Fahrzeuge mit explosiven Stoffen, für Kleinfahrzeuge verboten.', N'Liegestelle für alle Fahrzeuge, für Kleinfahrzeuge verboten.', N'Liegestelle für Fahrzeuge mit gesundheitsgefährdeten Stoffen, für Kleinfahrzeuge verboten.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (108, N'Was bedeuten diese Tafelzeichen? {Binnen108.gif}', N'Liegestelle für Fahrzeuge ohne gefährliche Güter, nicht für Kleinfahrzeuge.', N'Liegestelle für Fahrzeuge mit gefährlichen Gütern, auch für Kleinfahrzeuge.', N'Liegestelle für Fahrzeuge ohne gefährliche Güter, auch für Kleinfahrzeuge.', N'Liegestelle für Fahrzeuge mit gefährlichen Gütern, nicht für Kleinfahrzeuge.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (109, N'Wo besteht ohne besondere Bezeichnung der Stellen bzw. Strecken ein allgemeines Liegeverbot?', N'Vor Brücken und Hochspannungsleitungen.', N'Vor Brücken und nach Hochspannungsleitungen.', N'Auf Schifffahrtskanälen und Schleusenkanälen.', N'Auf Schifffahrtskanälen und vor Schleusenkanälen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (110, N'Welche Bedeutung hat das nachstehende Tafelzeichen? {Binnen110.gif}', N'Empfohlene Durchfahrtsöffnung, Durchfahrt in beide Richtungen erlaubt.', N'Die Durchfahrt ist nur durch diese Brückenöffnung und nur in eine Richtung gestattet.', N'Die Durchfahrt ist nur durch diese Brückenöffnung und in beide Richtungen gestattet.', N'Empfohlene Durchfahrt, Durchfahrt in Gegenrichtung verboten.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (111, N'Welche Bedeutung haben die nachstehenden Tafelzeichen?{Binnen111.gif}', N'Die Durchfahrt ist nur durch diese Brückenöffnung und in beide Richtungen gestattet.', N'Empfohlene Durchfahrt, Durchfahrt in Gegenrichtung verboten.', N'Die Durchfahrt ist nur durch diese Brückenöffnung und nur in eine Richtung gestattet.', N'Empfohlene Durchfahrtsöffnung, Durchfahrt in beide Richtungen erlaubt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (112, N'Was bedeuten diese Tafelzeichen an Brücken?  {Binnen112.gif}', N'Durchfahrt nur zwischen den beiden Tafeln erlaubt.', N'Empfohlene Durchfahrt mit Gegenverkehr.', N'Empfohlene Durchfahrt nur zwischen den beiden Tafeln.', N'Durchfahrt nur außerhalb der beiden Tafeln erlaubt.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (113, N'Was bedeuten diese Tafelzeichen an Brücken?  {Binnen113.gif}', N'Empfohlene Durchfahrt mit Gegenverkehr.', N'Empfohlene Durchfahrt nur zwischen den beiden Tafeln.', N'Durchfahrt nur außerhalb der beiden Tafeln erlaubt.', N'Durchfahrt nur zwischen den beiden Tafeln erlaubt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (114, N'Was bedeutet dieses Tafelzeichen an Brücken? {Binnen114.gif}', N'Empfohlene Durchfahrt nur in eine Richtung.', N'Empfohlene Durchfahrt mit Gegenverkehr.', N'Durchfahrt nur neben der Tafel erlaubt.', N'Empfohlene Durchfahrt ohne Gegenverkehr.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (115, N'Was bedeuten diese Tafelzeichen an Brücken? {Binnen115.gif}', N'Empfohlene Durchfahrt in beide Richtungen.', N'Empfohlene Durchfahrt mit Gegenverkehr.', N'Empfohlene Durchfahrt ohne Gegenverkehr.', N'Durchfahrt nur außerhalb der beiden Tafeln erlaubt.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (116, N'Was bedeutet dieses Tafelzeichen im Bereich eines Wehres? {Binnen116.gif}', N'Gesperrte Wasserfläche, jedoch für Kleinfahrzeuge mit Antriebsmaschine befahrbar.', N'Verbot der Durchfahrt und Sperrung der Schifffahrt.', N'Schutzbedürftige Anlage.', N'Gesperrte Wasserfläche, jedoch für Kleinfahrzeuge ohne Antriebsmaschine befahrbar.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (117, N'Welche Bedeutung haben vor einer Schleuse ein rotes oder ein rotes und ein grünes Licht?', N'Ausfahrt verboten, Öffnen der Schleuse wird vorbereitet.', N'Einfahrt verboten, Öffnen der Schleuse wird vorbereitet.', N'Einfahrt verboten, schließen der Schleuse wird vorbereitet.', N'Ausfahrt verboten, schließen der Schleuse wird vorbereitet.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (118, N'In welcher Reihenfolge fahren Fahrzeuge, die nicht Kleinfahrzeuge sind, und Kleinfahrzeuge, die gemeinsam geschleust werden sollen, in die Schleuse ein?', N'Kleinfahrzeuge fahren nach den Fahrzeugen, die nicht Kleinfahrzeuge sind und ohne Aufforderung durch die Schleusenaufsicht in die Schleuse ein.', N'Kleinfahrzeuge fahren erst nach den Fahrzeugen, die nicht Kleinfahrzeuge sind und nach Aufforderung durch die Schleusenaufsicht in die Schleuse ein.', N'Kleinfahrzeuge fahren vor den Fahrzeugen, die nicht Kleinfahrzeuge sind und ohne Aufforderung durch die Schleusenaufsicht in die Schleuse ein.', N'Kleinfahrzeuge fahren vor den Fahrzeugen, die nicht Kleinfahrzeuge sind und vor Aufforderung durch die Schleusenaufsicht in die Schleuse ein.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (119, N'Mehrere Kleinfahrzeuge sollen gemeinsam vom Oberwasser in das Unterwasser geschleust werden. Worauf ist bei deren Einfahrt in die Schleuse und während des Schleusens besonders zu achten?', N'Das erste Kleinfahrzeug muss so weit einfahren, dass es beim Leeren der Schleuse nicht auf den Drempel aufsetzen kann. Die Festmacherleinen sind so zu bedienen, dass Stöße gegen Schleusenwände, Schleusentore, andere Fahrzeuge vermieden werden und ein sicheres Fieren der Leinen möglich ist.', N'Das letzte Kleinfahrzeug muss so weit einfahren, dass es beim Füllen der Schleuse nicht auf den Drempel aufsetzen kann. Die Festmacherleinen sind so zu bedienen, dass Stöße gegen Schleusenwände, Schleusentore, andere Fahrzeuge vermieden werden und ein sicheres Fieren der Leinen möglich ist.', N'Das letzte Kleinfahrzeug muss so weit einfahren, dass es beim Leeren der Schleuse nicht auf den Drempel aufsetzen kann. Die Festmacherleinen sind so zu bedienen, dass Stöße gegen Schleusenwände, Schleusentore, andere Fahrzeuge vermieden werden und ein sicheres Fieren der Leinen möglich ist.', N'Das erste Kleinfahrzeug muss so weit einfahren, dass es beim Füllen der Schleuse nicht auf den Drempel aufsetzen kann. Die Festmacherleinen sind so zu bedienen, dass Stöße gegen Schleusenwände, Schleusentore, andere Fahrzeuge vermieden werden und ein sicheres Fieren der Leinen möglich ist.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (120, N'Was bedeuten diese Lichter? {Binnen120.gif}', N'Schubverband länger als 110 m.', N'Fahrzeug mit Maschinenantrieb länger als 110 m.', N'Fahrzeug ohne Maschinenantrieb länger als 110 m.', N'Schubverband kürzer als 110 m.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (121, N'Was bedeutet dieses Sichtzeichen?{Binnen121.gif}', N'Fahrzeug, das vor Anker liegt.', N'Fahrzeuge mit Vorrang an einer Schleuse.', N'Fahrzeug eines Schleppverbandes.', N'Schleppfahrzeug an der Spitze eines Schleppverbandes.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (122, N'Was bedeutet dieses Sichtzeichen? {Binnen122.gif}', N'Schleppfahrzeug an der Spitze eines Schleppverbandes.', N'Fahrzeuge mit Vorrang an einer Schleuse.', N'Fahrzeug eines Schleppverbandes.', N'Fahrzeug, das vor Anker liegt.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (123, N'Was bedeuten diese Lichter? {Binnen123.gif}', N'Schubverband vor Anker liegend.', N'Schubverband in Fahrt von achtern.', N'Schubverband unter 110 m Länge.', N'Schubverband in Fahrt von vorne.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (124, N'Was bedeuten diese Lichter?  {Binnen124.gif}', N'Nicht frei fahrende Fähre.', N'Schubverband von Steuerbordseite.', N'Schubverband von achtern.', N'Frei fahrende Fähre.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (125, N'Was bedeuten diese Lichter? {Binnen125.gif}', N'Schubverband von achtern.', N'Nicht frei fahrende Fähre.', N'Schubverband von Steuerbordseite.', N'Frei fahrende Fähre.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (126, N'Was bedeutet auf einem Fahrzeug ein blaues Licht?', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (127, N'Was bedeutet dieses Sichtzeichen? {Binnen127.gif}', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (128, N'Was bedeuten auf einem Fahrzeug zwei blaue Lichter übereinander?', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (129, N'Was bedeutet dieses Sichtzeichen? {Binnen129.gif}', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (130, N'Was bedeuten auf einem Fahrzeug drei blaue Lichter übereinander?', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (131, N'Was bedeutet dieses Sichtzeichen? {Binnen131.gif}', N'Fahrzeug hat brennbare Stoffe geladen, Abstand beim Stillliegen 10 m.', N'Fahrzeug hat gesundheitsschädliche Stoffe geladen, Abstand beim Stillliegen 50 m.', N'Fahrzeug der Überwachungsbehörden im Einsatz.', N'Fahrzeug hat explosive Stoffe geladen, Abstand beim Stillliegen 100 m.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (132, N'Welches Fahrzeug führt die nachstehende Tagbezeichnung? {Binnen132.gif}', N'Geschlepptes Fahrzeug eines Schleppverbandes.', N'Festgefahrenes Fahrzeug, das einseitig nicht passierbar ist.', N'Ein Fahrzeug, dem die zuständige Behörde einen Vorrang zur Durchfahrt durch Stellen an denen eine bestimmte Reihenfolge gilt eingeräumt hat.', N'Fahrzeug unter 20 m Länge, für mehr als 12 Fahrgäste zugelassen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (133, N'Ein Kleinfahrzeug unter Segel fährt nachts auf einer Binnenschifffahrtsstraße und führt ein weißes Rundumlicht im Topp. Wie wird zweckmäßigerweise die weiße Handlampe, die bei Annäherung anderer Fahrzeuge gezeigt werden muss, benutzt?', N'Das heranfahrende Fahrzeug anleuchten.', N'Die Handlampe nach oben halten.', N'Das Wasser anleuchten.', N'Die eigenen Segel anleuchten.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (134, N'Ein Kleinfahrzeug unter Segel fährt nachts auf einer Binnenschifffahrtsstraße und führt ein weißes Rundumlicht im Topp. Welche zusätzlichen Lichter müssen gesetzt werden, wenn der Motor angeworfen wird?', N'Es muss kein weiteres Licht geführt werden.', N'Es muss ein zweites weißes Topplicht geführt werden.', N'Es muss ein weißes Funkellicht geführt werden.', N'Seitenlichter unmittelbar nebeneinander oder in einer einzigen Laterne.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (135, N'Welche Lichter muss ein Kleinfahrzeug unter Motor führen, wenn es ein anderes Kleinfahrzeug ohne Maschinenantrieb schleppt?', N'Zwei weiße Lichter übereinander.', N'Weißes Rundumlicht.', N'Lichter eines Kleinfahrzeugs mit Maschinenantrieb.', N'Lichter eines Kleinfahrzeugs mit Maschinenantrieb und ein zweites weißes Topplicht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (136, N'Welche Lichter muss ein geschlepptes Kleinfahrzeug führen?', N'Zwei weiße Lichter übereinander.', N'Weißes Funkellicht.', N'Weißes Rundumlicht.', N'Lichter eines Kleinfahrzeugs mit Maschinenantrieb.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (137, N'Wann gilt ein Sportboot auf den Binnenschifffahrtsstraßen nicht mehr als Kleinfahrzeug?', N'Wenn es 18 m oder länger ist.', N'Wenn es 20 m oder länger ist.', N'Wenn es 15 m oder länger ist.', N'Wenn es 10 m oder länger ist.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (138, N'Welchen Sichtwinkel und welche Farben haben die vorgeschriebenen Lichter an Bord?', N'Topplicht: weiß 225°, Hecklicht 112,5° weiß, Seitenlichter: Backbord rot und Steuerbord grün, jeweils 135°.', N'Topplicht: weiß 135°, Hecklicht 225° weiß, Seitenlichter: Backbord rot und Steuerbord grün, jeweils 112,5°.', N'Topplicht: weiß 112,5°, Hecklicht 225° weiß, Seitenlichter: Backbord rot und Steuerbord grün, jeweils 112,5°.', N'Topplicht: weiß 225°, Hecklicht 135° weiß, Seitenlichter: Backbord rot und Steuerbord grün, jeweils 112,5°.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (139, N'19. Welches Licht muss ein Kleinfahrzeug ohne Maschinenantrieb mindestens führen?', N'Seitenlichter.', N'Dreifarbenlaterne im Topp.', N'Topp- und Hecklicht.', N'Ein von allen Seiten sichtbares weißes Licht.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (140, N'Wie muss sich ein Segelfahrzeug auf einer Binnenschifffahrtsstraße, welches sich auf Kollisionskurs mit einem Kleinfahrzeug mit Maschinenantrieb befindet, verhalten?', N'Es wechselt den Kurs nach steuerbord und reduziert die Geschwindigkeit.', N'Es hält Kurs und Geschwindigkeit bei.', N'Es wechselt den Kurs nach steuerbord und hält die Geschwindigkeit.', N'Es hält Kurs und reduziert die Geschwindigkeit.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (141, N'Wie muss sich ein Fahrzeug mit Topplicht und Seitenlichtern gegenüber einem Kleinfahrzeug mit Seitenlichtern, welches sich auf Kollisionskurs befindet, verhalten?', N'Es hält Kurs und Geschwindigkeit bei.', N'Es wechselt den Kurs nach steuerbord und reduziert die Geschwindigkeit.', N'Es muss ausweichen.', N'Es hält Kurs und reduziert die Geschwindigkeit.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (142, N'Wie muss sich ein Kleinfahrzeug mit Maschinenantrieb gegenüber einem Segelsurfer, der auf Kollisionskurs liegt, verhalten?', N'Es hält Kurs und Geschwindigkeit bei.', N'Es hält Kurs und reduziert die Geschwindigkeit.', N'Es muss ausweichen.', N'Es muss nicht ausweichen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (143, N'Wer ist ausweichpflichtig, wenn ein Segler mit Wind von Backbord einer Segelyacht, mit Wind von Steuerbord und einem schwarzen Kegel, auf Kollisionskurs begegnet?', N'Die Segelyacht mit Wind von Backbord, weil sie als Kleinfahrzeug unter Segel gilt.', N'Die Segelyacht mit Wind von Steuerbord, weil sie als Kleinfahrzeug unter Segel gilt.', N'Die Segelyacht mit Wind von Steuerbord, weil sie als Kleinfahrzeug mit Maschinenantrieb gilt.', N'Beide Segelyachten, weil eines als Kleinfahrzeug mit Maschinenantrieb gilt und das andere den Wind von Backbord hat.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (144, N'Wie lautet eine der drei Grundregeln der Binnenschifffahrtsstraßen- Ordnung, nach denen Kleinfahrzeuge unter Segel einander ausweichen?', N'Wenn sie den Wind nicht von derselben Seite haben, muss das Segelfahrzeug mit Wind von Steuerbord dem Segelfahrzeug mit Wind von Backbord ausweichen.', N'Wenn sie den Wind von derselben Seite haben, muss das leeseitige dem luvseitigen ausweichen.', N'Wenn sie den Wind nicht von derselben Seite haben, muss das Segelfahrzeug mit Wind von Backbord dem Segelfahrzeug mit Wind von Steuerbord ausweichen.', N'Wenn sie den Wind von derselben Seite haben, müssen beide Fahrzeuge ausweichen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (145, N'Was bedeuten diese Lichter? {Binnen145.gif}', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Steuerbordseite gestattet. Sog und Wellenschlag vermeiden.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt nicht gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an jeder Seite gestattet. Sog und Wellenschlag vermeiden.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (146, N'Was bedeuten diese Sichtzeichen? {Binnen146.gif}', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt nicht gestattet.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Steuerbordseite gestattet. Sog und Wellenschlag vermeiden.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an jeder Seite gestattet. Sog und Wellenschlag vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (147, N'Was bedeuten diese Lichter? {Binnen147.gif}', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der roten Seite gestattet; rot-weiße Seite gesperrt. Vorbeifahrt mit unverminderter Geschwindigkeit möglich.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der rot-weißen Seite gestattet; rote Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der roten Seite gestattet; rot-weiße Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der rot-weißen Seite gestattet; rote Seite gesperrt. Vorbeifahrt mit unverminderter Geschwindigkeit möglich.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (148, N'Was bedeuten diese Sichtzeichen?  {Binnen148.gif}', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der rote Seite gestattet; rot-weiße Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der roten Seite gestattet; rot-weiße Seite gesperrt. Vorbeifahrt mit unverminderter Geschwindigkeit möglich.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der rot-weißen Seite gestattet; rote Seite gesperrt. Vorbeifahrt mit unverminderter Geschwindigkeit möglich.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der rot-weißen Seite gestattet; rote Seite gesperrt. Sog und Wellenschlag vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (149, N'Was bedeuten diese Lichter?  {Binnen149.gif}', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet; rote Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der roten Seite gestattet; grüne Seite gesperrt.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet; rote Seite gesperrt.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet. Vorbeifahrt an der roten Seite mit unverminderter Geschwindigkeit möglich.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (150, N'Was bedeuten diese Sichtzeichen? {Binnen150.gif}', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet; rote Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet. Vorbeifahrt an der roten Seite mit unverminderter Geschwindigkeit möglich.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der grünen Seite gestattet; rote Seite gesperrt.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der roten Seite gestattet; grüne Seite gesperrt.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (151, N'Was bedeuten im Fahrwasser nachstehende Zeichen? {Binnen151.gif}', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der Seite mit dem grün-weiß-grünen Tafelzeichen gestattet; rot-weiß-rote Seite gesperrt. Sog und Wellenschlag vermeiden.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an der Seite mit dem grün-weiß-grünen Tafelzeichen gestattet; rot-weiß-rote Seite gesperrt.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Seite mit dem rot-weiß-roten Tafelzeichen gestattet; grün-weiß-grüne Seite gesperrt.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Seite mit dem grün-weiß-grünen Tafelzeichen gestattet; rot-weiß-rote Seite gesperrt. Sog und Wellenschlag vermeiden.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (152, N'Was bedeuten diese Lichter?  {Binnen152.gif}', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Steuerbordseite gestattet.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an jeder Seite gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt nicht gestattet.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (153, N'Was bedeuten diese Sichtzeichen? {Binnen153.gif}', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Steuerbordseite gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt nicht gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an jeder Seite gestattet.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (154, N'Was bedeuten diese Sichtzeichen? {Binnen154.gif}', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt an jeder Seite gestattet.', N'Schwimmendes Gerät bei der Arbeit. Vorbeifahrt nicht gestattet.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an der Steuerbordseite gestattet. Sog und Wellenschlag vermeiden.', N'Festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (155, N'Was bedeutet diese Tag- und Nachtbezeichnung?  {Binnen155.gif}', N'Schwimmende Anlage / Schwimmkörper. Vorbeifahrt in möglichst weitem Abstand, Geschwindigkeit vermindern, Sog und Wellenschlag vermeiden.', N'Ein festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt an jeder Seite mit unverminderter Geschwindigkeit gestattet.', N'Ein festgefahrenes oder gesunkenes Fahrzeug. Vorbeifahrt nicht gestattet.', N'Schutzbedürftiges Fahrzeug, Vorbeifahrt in möglichst weitem Abstand, Geschwindigkeit vermindern, Sog und Wellenschlag vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (156, N'Was bedeutet dieses Tafelzeichen? {Binnen156.gif}', N'Gesperrte Wasserfläche, für Kleinfahrzege nicht befahrbar.', N'Gesperrte Wasserfläche, jedoch für Kleinfahrzeuge ohne Antriebsmaschine befahrbar.', N'Gesperrte Wasserfläche, jedoch für Kleinfahrzeuge ohne laufende Antriebsmaschine befahrbar.', N'Gesperrte Wasserfläche, Verbot der Durchfahrt und Sperrung der Schifffahrt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (157, N'Was bedeutet dieses Tafelzeichen? {Binnen157.gif}', N'Fahrverbot für Kleinfahrzeuge mit Maschinenantrieb.', N'Fahrverbot für Fahrzeuge mit Maschinenantrieb.', N'Fahrverbot für Kleinfahrzeuge ohne laufende Antriebsmaschine.', N'Fahrverbot für Fahrzeuge ohne Antriebsmaschine.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (158, N'Wie ist eine geschützte Badezone gekennzeichnet?', N'Durch rot-grün gestreifte Tonnen.', N'Durch rote Tonnen.', N'Durch gelbe Tonnen.', N'Durch grüne Tonnen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (159, N'Was bedeutet ein langer Ton?', N'Maschine geht rückwärts.', N'Überholen nicht möglich.', N'Fahrzeug ist manövrierunfähig.', N'Achtung!', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (160, N'Was bedeuten vier kurze Töne? ', N'Maschine geht rückwärts.', N'Fahrzeug ist manövrierunfähig.', N'Überholen nicht möglich.', N'Achtung!', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (161, N'Was bedeuten fünf kurze Töne?', N'Achtung!', N'Maschine geht rückwärts.', N'Fahrzeug ist manövrierunfähig.', N'Überholen nicht möglich.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (162, N'Was bedeutet dieses Schallsignal? (— •)', N'Wenden über Backbord.', N'Wenden über Steuerbord.', N'Kursänderung nach Backbord.', N'Kursänderung über Steuerbord.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (163, N'Was bedeutet dieses Schallsignal? (— • •)', N'Kursänderung nach Steuerbord.', N'Wenden über Steuerbord.', N'Kursänderung nach Backbord.', N'Wenden über Backbord.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (164, N'Was bedeutet dieses Schallsignal? (— — •)', N'Überholen an der Steuerbordseite des Vorausfahrenden.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Backbord.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Steuerbord.', N'Überholen an der Backbordseite des Vorausfahrenden.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (165, N'Was bedeutet dieses Schallsignal? (— — • •) ', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Steuerbord.', N'Überholen an der Backbordseite des Vorausfahrenden.', N'Überholen an der Steuerbordseite des Vorausfahrenden.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Backbord.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (166, N'Was bedeutet dieses Schallsignal? (— — — •)', N'Überholen an der Steuerbordseite des Vorausfahrenden.', N'Überholen an der Backbordseite des Vorausfahrenden.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Backbord.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Steuerbord.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (167, N'Was bedeutet dieses Schallsignal? (— — — • •)', N'Überholen an der Steuerbordseite des Vorausfahrenden.', N'Überholen an der Backbordseite des Vorausfahrenden.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Steuerbord.', N'Hafen oder Nebenwasserstraße; Ein- oder Ausfahrt mit Kursänderung nach Backbord.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (168, N'Was ist eine Folge sehr kurzer Töne?', N'Eine Folge von mindestens 2 Tönen von je etwa einer viertel Sekunde Dauer und mit je einer viertel Sekunde Pause.', N'Eine Folge von mindestens 8 Tönen von je etwa einer viertel Sekunde Dauer und mit je einer viertel Sekunde Pause.', N'Eine Folge von mindestens 6 Tönen, von je etwa einer viertel Sekunde Dauer und mit je einer viertel Sekunde Pause.', N'Eine Folge von mindestens 4 Tönen von je etwa einer viertel Sekunde Dauer und mit je einer viertel Sekunde Pause.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (169, N'Was bedeutet eine Folge sehr kurzer Töne?', N'Gefahr eines Zusammenstoßes.', N'Fahrzeug ist manövrierunfähig.', N'Überholen nicht möglich.', N'Achtung!', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (170, N'Welche Schallsignale bzw. Zeichen sind zu geben, wenn das Boot manövrierunfähig geworden ist? ', N'Fünf kurze Töne. Bei Tag eine rote Flagge, bei Nacht ein rotes Licht im oberen Halbkreis schwenken.', N'Eine Gruppe von kurzen und langen Tönen im Intervall geben. Bei Nacht ein rotes Blinklicht einschalten.', N'Vier kurze Töne. Bei Tag eine rote Flagge, bei Nacht ein rotes Licht im unteren Halbkreis schwenken.', N'Ein langer, vier kurze Töne. Bei Tag eine rote Flagge, bei Nacht ein rotes Licht setzen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (171, N'Ein Fahrzeug zeigt an der Steuerbordseite seines Ruderhauses eine blaue Tafel mit weißem Funkellicht. Welche Bedeutung hat dieses Zeichen?', N'Fahrzeuge begegnen sich an Steuerbord. Dieses Zeichen gilt nicht für Kleinfahrzeuge, verpflichtet aber zu erhöhter Aufmerksamkeit.', N'Fahrzeuge begegnen sich an Steuerbord. Dieses Zeichen gilt nur für Kleinfahrzeuge.', N'Fahrzeuge begegnen sich an Steuerbord. Dieses Zeichen gilt auch für alle Kleinfahrzeuge.', N'Fahrzeuge begegnen sich an Steuerbord. Dieses Zeichen braucht gar nicht beachtet zu werden.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (172, N'Ein Sportfahrzeug fährt hinter einem Fahrzeug, das nicht Kleinfahrzeug ist, in den Schleusenvorhafen ein. Aus der Schleusenkammer kommt ein Fahrzeug, das an Steuerbord eine blaue Tafel mit einem weißen Funkellicht zeigt. Was bedeutet dieses Zeichen? ', N'Das aus- und die einfahrenden Fahrzeuge passieren sich an der Backbordseite, das Kleinfahrzeug hat Vorrang.', N'Das aus- und die einfahrenden Fahrzeuge passieren sich an der Steuerbordseite, das Kleinfahrzeug ist wartepflichtig.', N'Das aus- und die einfahrenden Fahrzeuge passieren sich an der Backbordseite, das Kleinfahrzeug ist nur zu erhöhter Aufmerksamkeit verpflichtet.', N'Das aus- und die einfahrenden Fahrzeuge passieren sich an der Steuerbordseite, das Kleinfahrzeug ist nur zu erhöhter Aufmerksamkeit verpflichtet.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (173, N'Wo kann man von bestehenden Höchstgeschwindigkeiten auf den Binnenschifffahrtsstraßen Kenntnis erhalten?', N'In der Binnenschiffsuntersuchungs-Ordnung, bei der Wasser- und Schifffahrtsverwaltung und der Wasserschutzpolizei.', N'In der Sportbootführerscheinverordnung-Binnen, bei der Wasser- und Schifffahrtsverwaltung und der Wasserschutzpolizei.', N'In der Binnenschifferpatentverordnung, bei der Wasser- und Schifffahrtsverwaltung und der Wasserschutzpolizei.', N'In der Binnenschifffahrtsstraßen-Ordnung, bei der Wasser- und Schifffahrtsverwaltung und der Wasserschutzpolizei.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (174, N'Wie ist ein Überholmanöver durchzuführen?', N'Zügig überholen. Gegebenenfalls das Fahrzeug stark beschleunigen, um schnell passieren zu können.', N'Zügig überholen. Dicht am Ufer entlang fahren, eventuelle Schallzeichen müssen von Kleinfahrzeugen beachtet werden.', N'Zügig überholen; überholen nur auf der Steuerbordseite erlaubt, ausreichend Abstand halten.', N'Zügig überholen. Beteiligte Fahrzeuge nicht behindern. Verkehrslage und eventuelle Schallzeichen beachten. Ausreichend Abstand halten.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (175, N'Wann besteht die Gefahr eines Zusammenstoßes?', N'Wenn sich zwei Fahrzeuge einander nähern und sich der Kurs der Fahrzeuge nicht ändert.', N'Wenn sich zwei Fahrzeuge bei gleichbleibender Peilung einander nähern.', N'Wenn sich zwei Fahrzeuge einander nähern und beide Fahrzeuge ihren Kurs nach steuerbord ändern.', N'Wenn sich zwei Fahrzeuge einander nähern und sich der Kurs eines Fahrzeuges ändert.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (176, N'Wie müssen Ausweichmanöver durchgeführt werden?', N'Rechtzeitig, klar erkennbar und entschlossen.', N'Rechtzeitig, klar erkennbar und vorsichtig.', N'Rechtzeitig, klar erkennbar und nach Steuerbord.', N'Rechtzeitig, klar erkennbar und nach Backbord.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (177, N'Ein Kleinfahrzeug und ein Fahrzeug über 20 m Länge nähern sich auf kreuzenden Kursen. Es besteht die Gefahr eines Zusammenstoßes. Wer ist ausweichpflichtig?', N'Ausweichpflichtig ist das Fahrzeug über 20 m Länge.', N'Ausweichpflichtig ist das Kleinfahrzeug.', N'Ausweichpflichtig ist das Fahrzeug, welches das andere an seiner Steuerbordseite sieht.', N'Ausweichpflichtig ist das Fahrzeug, welches das andere an seiner Backbordseite sieht.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (178, N'Welche Fahrzeuge in Fahrt führen nachts nur ein weißes Rundumlicht?', N'Fahrzeuge die geschoben werden.', N'Längsseits gekuppelte Kleinfahrzeuge.', N'Kleinfahrzeuge mit Maschinenantrieb unter 15 m Länge.', N'Kleinfahrzeuge mit Maschinenantrieb und geschleppte Fahrzeuge.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (179, N'Wie muss sich ein kreuzendes Kleinfahrzeug unter Segel am Wind in der Nähe eines Ufers gegenüber einem anderen Kleinfahrzeug verhalten?', N'Es darf ein anderes Kleinfahrzeug, das sein steuerbordseitiges Ufer anhält, zum Ausweichen zwingen.', N'Es darf ein anderes Kleinfahrzeug, das sein steuerbordseitiges Ufer anhält, nicht zum Ausweichen zwingen.', N'Es darf ein anderes Kleinfahrzeug, das sein backbordseitiges Ufer verlässt, zum Ausweichen zwingen.', N'Es darf ein anderes Kleinfahrzeug, das sein steuerbordseitiges Ufer verlässt, nicht zum Ausweichen zwingen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (180, N'Wer ist ausweichpflichtig bzw. wer ist nicht ausweichpflichtig? {Binnen180.gif}', N'Das Fahrzeug unter Segel ist ausweichpflichtig.', N'Das Fahrzeug unter Segel ist nicht ausweichpflichtig.', N'Beide Fahrzeuge sind ausweichpflichtig.', N'Das Fahrzeug unter Maschinenantrieb ist ausweichpflichtig.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (181, N'Was hat der Schiffsführer eines Kleinfahrzeugs beim Begegnen mit Fahrzeugen, die nicht Kleinfahrzeuge sind, zu beachten? ', N'Kleinfahrzeuge sind gegenüber Fahrzeugen, die nicht Kleinfahrzeuge sind ausweichpflichtig. Sie brauchen aber keinen besonderen Raum zum Manövrieren frei zu geben.', N'Kleinfahrzeuge sind gegenüber Fahrzeugen, die nicht Kleinfahrzeuge sind, ausweichpflichtig. Sie müssen für deren Kurs und zum Manövrieren notwendigen Raum lassen.', N'Kleinfahrzeuge sind gegenüber anderen Fahrzeugen, die nicht Kleinfahrzeuge sind, nicht ausweichpflichtig.', N'Kleinfahrzeuge sind gegenüber Fahrzeugen, die nicht Kleinfahrzeuge sind bei der Begegnung gleichgestellt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (182, N'Von Backbord kommend kreuzt ein Fahrzeug unter Segel mit einem schwarzen Kegel, Spitze nach unten, den Kurs eines Fahrzeuges mit Maschinenantrieb. Wer ist ausweichpflichtig?', N'Das Fahrzeug unter Segel mit einem schwarzen Kegel ist nicht ausweichpflichtig.', N'Das Fahrzeug unter Segel mit einem schwarzen Kegel ist ausweichpflichtig.', N'Beide Fahrzeuge sind ausweichpflichtig.', N'Das Fahrzeug ohne Segel ist ausweichpflichtig.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (183, N'Zwei Kleinfahrzeuge unter Segel A und B liegen auf Kollisionskurs; A führt einen schwarzen Kegel. Wer ist ausweichpflichtig? {Binnen183.gif} ', N'Fahrzeug B ist ausweichpflichtig.', N'Ausweichpflichtig ist das Fahrzeug, welches den Wind von Backbord hat.', N'Fahrzeug A ist ausweichpflichtig.', N'Ausweichpflichtig ist das Fahrzeug, welches das Andere an seiner Backbordseite sieht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (184, N'Ein Fahrzeug unter Segel kreuzt eine Binnenschifffahrtsstraße. In der Fahwassermitte kommt ihm ein Kleinfahrzeug mit Maschinenantrieb zu Berg entgegen. Wer ist ausweichpflichtig?', N'Fahrzeug in der Talfahrt.', N'Beide sind ausweichpflichtig.', N'Fahrzeug mit Maschinenantrieb.', N'Fahrzeug unter Segel.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (185, N'Zwei Kleinfahrzeuge A und B unter Segel liegen auf Kollisionskurs (Skizze). Wer ist ausweichpflichtig? {Binnen185.gif}', N'B ist ausweichpflichtig. Segelfahrzeuge mit Wind von Backbord müssen Segelfahrzeugen mit Wind von Steuerbord ausweichen.', N'B ist ausweichpflichtig. Segelfahrzeuge mit Wind von Steuerbord müssen Segelfahrzeugen mit Wind von Backbord ausweichen.', N'A ist ausweichpflichtig. Segelfahrzeuge mit Wind von Steuerbord müssen Segelfahrzeugen mit Wind von Backbord ausweichen.', N' ist ausweichpflichtig. Segelfahrzeuge mit Wind von Backbord müssen Segelfahrzeugen mit Wind von Steuerbord ausweichen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (186, N'Zwei Kleinfahrzeuge unter Segel liegen auf Kollisionskurs. Wer ist ausweichpflichtig? {Binnen186.gif}', N'A ist ausweichpflichtig. Das leeseitige Boot muss dem luvseitigen ausweichen.', N'B ist ausweichpflichtig. Das luvseitige Boot muss dem leeseitigen ausweichen.', N'B ist ausweichpflichtig. Das leeseitige Boot muss dem luvseitigen ausweichen.', N'A ist ausweichpflichtig. Das luvseitige Boot muss dem leeseitigen ausweichen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (187, N'Ein Kleinfahrzeug A segelt nachts auf Vorwindkurs stromab, Großsegel an Steuerbord. Backbord querab kommt ein grünes Seitenlicht eines Bootes B immer näher, das kein Topplicht führt. Wer ist ausweichpflichtig?', N'Das Kleinfahrzeug A ist ausweichpflichtig. Ein Boot mit Wind von Backbord muss ausweichen, wenn es nicht klar ausmachen kann, ob das luvseitige Boot den Wind von Steuerbord hat.', N'Das Kleinfahrzeug A ist ausweichpflichtig. Ein Boot mit Wind von Steuerbord muss ausweichen, wenn es nicht klar ausmachen kann, ob das luvseitige Boot den Wind von Backbord hat.', N'Boot B ist ausweichpflichtig, weil es sich um ein Kleinfahrzeug handelt und Kleinfahrzeuge anderen Kleinfahrzeugen unter Segel ausweichen müssen.', N'Boot B ist ausweichpflichtig, weil es sich bei Fahrzeug A um ein Kleinfahrzeug unter Segel handelt, das den Wind von Backbord hat.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (188, N'Der seitliche Abstand zwischen den Booten A, B und C verringert sich ständig. Welches Boot kann seinen Kurs beibehalten?  {Binnen188.gif}', N'Boot A, weil luvseitig.', N'Boot A, weil leeseitig.', N'Boot B, weil leeseitig.', N'Boot C, weil leeseitig.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (189, N'Wer ist wem gegenüber kurshaltepflichtig?  {Binnen189.gif}', N'B gegenüber C und A, A gegenüber C.', N'C gegenüber A und B, B gegenüber A.', N'A gegenüber B und C, B gegenüber C.', N'A gegenüber B und C, C gegenüber B.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (190, N'Was ist vorrangig zu beachten, wenn eine Jolle gekentert ist und sie nicht wieder aufgerichtet werden kann?', N'Vollständigkeit der Crew überprüfen, gegebenenfalls Hilfe leisten. Am Boot festhalten oder gegebenenfalls aufs Boot legen, Hilfe abwarten.', N'Rettungswesten anlegen und mit geeigneten Mitteln Hilfe herbeiholen. Gegebenenfalls Segel bergen.', N'Auf das gekenterte Boot steigen und sich ruhig verhalten, um Wärmeverlust zu minimieren. Sollte das nicht möglich sein, ans benachbarte Ufer schwimmen und Hilfe holen.', N'Sofort vorgeschriebene Notsignale geben, mit allen Mitteln versuchen, das Fahrzeug aus dem Fahrwasser zu bringen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (191, N'Ein Segelboot gerät in das Feld einer Segelregatta, ohne selbst Teilnehmer zu sein. Welche Ausweichregeln sind zu beachten? ', N'Die der Wettsegelbestimmungen.', N'Fahrzeuge, die an einer Regatta teilnehmen, müssen unbeteiligten Fahrzeugen ausweichen.', N'Die der Binnenschifffahrtsstraßen-Ordnung.', N'Gegenüber Regattateilnehmern, die der Wettfahrtregeln, gegenüber anderen Fahrzeugen die der Binnenschifffahrtsstraßenordnung.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (192, N'Ein Kleinfahrzeug unter Segel kreuzt nachts das Fahrwasser. An Backbord tauchen die nachstehenden Lichter eines Fahrzeugs auf, das in spitzem Winkel den Kurs des Kleinfahrzeugs unter Segel kreuzen will. Was bedeuten diese Lichter? {Binnen192.gif} ', N'Kleinfahrzeug mit Maschinenantrieb.', N'Frei fahrende Fähre.', N'Geschlepptes Kleinfahrzeug.', N'Schubverband von vorne.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (193, N'Ein Kleinfahrzeug unter Segel kreuzt nachts das Fahrwasser. An Backbord tauchen die nachstehenden Lichter eines Fahrzeugs auf, das in spitzem Winkel den Kurs des Kleinfahrzeugs unter Segel kreuzen will. Wer ist ausweichpflichtig? {Binnen193.gif}', N'Kleinfahrzeug mit Maschinenantrieb.', N'Kleinfahrzeug, welches das Andere auf der Backbordseite hat.', N'Beide sind ausweichpflichtig.', N'Kleinfahrzeug unter Segel.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (194, N'Ein Kleinfahrzeug unter Segel und mit Maschinenantrieb kreuzt nachts stromauf. Ein Fahrzeug kommt entgegen, das nur ein weißes Licht führt. Was bedeutet dieses Licht?', N'Kleinfahrzeug unter Segel mit Maschinenantrieb.', N'Kleinfahrzeug unter Segel.', N'Kleinfahrzeug ohne Maschinenantrieb.', N'Kleinfahrzeug mit Maschinenantrieb.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (195, N'Ein Kleinfahrzeug unter Segel kreuzt nachts im Fahrwasser. Von achtern kommt ein Fahrzeug auf das eine Zweifarbenlaterne und ein Topplicht führt. Was bedeuten diese Lichter?', N'Kleinfahrzeug ohne Maschinenantrieb.', N'Kleinfahrzeug unter Segel mit Maschinenantrieb.', N'Kleinfahrzeug mit Maschinenantrieb.', N'Kleinfahrzeug unter Segel.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (196, N'Was bedeuten nachts auf einer Binnenschifffahrtsstraße die nachstehenden Lichter? {Binnen196.gif}', N'Sog und Wellenschlag vermeiden.', N'Sperrung der Schifffahrt.', N'Keine Durchfahrt für Kleinfahrzeuge.', N'Durchfahrt für Kleinfahrzeuge.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (197, N'Wo ist die Geschwindigkeit zu vermindern, um Sog und Wellenschlag zu vermeiden?', N'Vor Hafenmündungen, an Lade-, Lösch- und Liegeplätzen, in der Nähe frei fahrender Fähren, auf gekennzeichneten Strecken, in der Nähe schwimmender Geräte bei der Arbeit.', N'Vor Hafenmündungen, an Lade-, Lösch- und Liegeplätzen, in der Nähe nicht frei fahrender Fähren, auf gekennzeichneten Strecken, in der Nähe schwimmender Geräte bei der Arbeit.', N'Vor Einmündungen, an Lade-, Lösch- und Liegeplätzen, in der Nähe nicht frei fahrender Fähren, auf gekennzeichneten Strecken, in der Nähe schwimmender Geräte bei der Arbeit.', N'Vor Hafenmündungen, an Lade-, Lösch- und Liegeplätzen, in der Nähe nicht frei fahrender Fähren, auf gekennzeichneten Strecken, in der Nähe schwimmender Schifffahrtszeichen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (198, N'Was bedeutet dieses Tafelzeichen? {Binnen198.gif}', N'Vorgeschriebene Fahrtrichtung.', N'Empfohlene Fahrtrichtung.', N'Fahrtrichtung nach links verboten.', N'Vorgeschriebene Fahrtrichtung nur für Kleinfahrzeuge.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (199, N'Welche Bedeutung hat das nachstehende Tafelzeichen, wenn das rote Licht leuchtet? {Binnen199.gif}', N'Achtung Ausfahrt aus Hafen oder Nebenfahrwasser.', N'Verbot des Überholens auf dem Streckenabschnitt.', N'Verbot der Einfahrt in einen Hafen oder eine Nebenwasserstraße.', N'Achtung Doppelschleuse, linke Kammer gesperrt.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (200, N'Was bedeutet dieses Tafelzeichen?  {Binnen200.gif}', N'10 km/h Höchstgeschwindigkeit gegenüber dem Ufer.', N'10 km/h Höchstgeschwindigkeit gegenüber der Strömung.', N'10 km/h Höchstgeschwindigkeit für Kleinfahrzeuge.', N'10 km/h für größere Fahrzeuge.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (201, N'Was bedeutet dieses Tafelzeichen?  {Binnen201.gif}', N'Gebot: Besondere Vorsicht walten lassen.', N'Gebot: Geradeaus zu fahren.', N'Gebot: Vor dem Schild anhalten.', N'Gebot: Achtungssignal geben.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (202, N'Was bedeutet dieses Tafelzeichen? {Binnen202.gif}', N'Wendeverbot.', N'Verbotene Fahrtrichtung rechts oder links.', N'Wendeverbot in der Mitte des Fahrwassers.', N'Verbote in beiden angezeigten Richtungen zu fahren.', 1)
GO
print 'Processed 200 total records'
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (203, N'Was bedeutet dieses Tafelzeichen? {Binnen203.gif}', N'Empfohlener Wendeplatz. Stillliegen von Kleinfahrzeugen erlaubt.', N'Empfohlener Wendeplatz. Stillliegen für alle Fahrzeuge verboten.', N'Vorgeschriebener Wendeplatz. Stillliegen für alle Fahrzeuge verboten.', N'Vorgeschriebener Wendeplatz. Stillliegen von Kleinfahrzeugen erlaubt.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (204, N'Was bedeutet dieses Tafelzeichen? {Binnen204.gif}', N'Wehr.', N'Hubbrücke.', N'Schleuse.', N'Sicherheitstor.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (205, N'Welche Sichtbeeinträchtigungen führen zu unsichtigem Wetter?', N'Dämmerung, Nebel, Schneefall, starker Regen.', N'Nebel, Schneefall, starker Regen.', N'Nacht, Schneefall, starker Regen.', N'Dunkelheit, Nebel, Schneefall, starker Regen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (206, N'Wie muss ein Fahrzeug ausgerüstet sein, um bei unsichtigem Wetter zu fahren?', N'Mit einer für die Binnenschifffahrt zugelassenen funktionsfähigen Radaranlage und einer Sprechfunkanlage für den Seefunkdienst.', N'Mit einer für die Binnenschifffahrt zugelassenen funktionsfähigen Radaranlage und einer Sprechfunkanlage für den Binnenschifffahrtsfunk.', N'Mit einer für die Binnenschifffahrt zugelassenen funktionsfähigen Radaranlage und einer Sprechfunkanlage ohne ATIS.', N'Mit einer Radaranlage ohne Wendeanzeiger und einer Sprechfunkanlage für den Binnenschifffahrtsfunk.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (207, N'Was ist zu beachten, wenn während der Fahrt unsichtiges Wetter eintritt?', N'Auf bestimmten Wasserstraßen ist ohne Radar und AIS die Fahrt unverzüglich einzustellen.', N'Auf allen Wasserstraßen ist ohne Radar und Sprechfunk die Fahrt unverzüglich einzustellen.', N'Auf allen Wasserstraßen ist ohne Radar und ECDIS die Fahrt unverzüglich einzustellen.', N'Auf bestimmten Wasserstraßen ist ohne Radar und Sprechfunk die Fahrt unverzüglich einzustellen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (208, N'Welchen Vorteil bietet ein Radarreflektor auf einem Sportboot?', N'Bessere Erkennbarkeit des Sportbootes bei unsichtigem Wetter.', N'Bessere Erkennbarkeit des Sportbootes bei Taglicht.', N'Bessere Erkennbarkeit des Sportbootes auf Radarbildschirmen.', N'Bessere Erkennbarkeit des Sportbootes bei Nacht.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (209, N'Welche technische Einrichtung gegen einen Stromschlag muss in der Landstromversorgung unbedingt installiert sein?', N'Ein Fehlerstromschutzschalter.', N'Ein Überspannungsschutz.', N'Ein geringer Ladungsstrom ist ungefährlich.', N'Ein Schutzkleinspannungsschalter.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (210, N'Welches Schallsignal ist zu geben, wenn in einer Notsituation Hilfe gebraucht wird?', N'Wiederholte lange Töne geben oder Gruppen von Glockenschlägen.', N'Drei kurze Töne geben, keine Glockenschläge.', N'Einen langen Ton geben, vereinzelt Glockenschläge.', N'Wiederholte kurze Töne geben, keine Glockenschläge.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (211, N'Welche Bedeutung hat am Tag das Kreisen einer roten Flagge auf einem Wasserfahrzeug?', N'Ein manövrierbehindertes Fahrzeug, das durch Sichtzeichen Hilfe herbeirufen will.', N'Schützenswertes Fahrzeug, Vermeidung von Sog und Wellenschlag.', N'Ein in Not befindliches Fahrzeug, das durch Sichtzeichen Hilfe herbeirufen will.', N'Keine Bedeutung für den durchgehenden Schiffsverkehr.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (212, N'Welche Notsignale kann ein Segelsurfer auf Binnenschifffahrtsstraßen geben?', N'Kreisförmiges Schwenken einer grünen Flagge, die mit anderen Zeichen nicht verwechselt werden kann.', N'Kreisförmiges Schwenken der Arme oder eines Gegenstandes.', N'Wiederholt lange Gruppen von Glockenschlägen.', N'Kreisförmiges Schwenken der Arme ist zu vermeiden, das Surfsegel ist möglichst senkrecht zu stellen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (213, N'Was ist mit Abfällen jeglicher Art zu tun, die an Bord anfallen?', N'An Bord sammeln und bei einer Liegestelle an Land stellen.', N'An Bord sammeln. Die Abgabe ist an jeder Schleuse möglich.', N'An Bord sammeln und nur in geschlossenen Behältern über Bord werfen.', N'An Bord sammeln und an Land in den entsprechenden Abfallsammelbehältern umweltgerecht entsorgen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (214, N'Wem darf der Schiffsführer das Ruder eines motorisierten Sportbootes überlassen?', N'Einer Person jeden Alters, die körperlich und geistig geeignet ist.', N'Einer Person, die mindestens 16 Jahre alt, sowie körperlich und geistig geeignet ist.', N'Einer Person, die mindestens 18 Jahre alt, sowie körperlich und geistig geeignet ist.', N'Einer Person, die mindestens 14 Jahre alt, sowie körperlich und geistig geeignet ist.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (215, N'Wie müssen Abfälle entsorgt werden?', N'Es dürfen keinerlei Abfälle ins Wasser gelangen, Fäkalien und Öle sind an Land zu entsorgen.', N'Alle Schiffe müssen mit Fäkalientanks ausgerüstet sein und geeignete Behältnisse für die getrennte Aufnahme von Abfällen an Bord haben.', N'Auf Seen dürfen keine Abfälle ins Wasser gelangen, auf Binnenschifffahrtsstraßen gibt es Sonderregelungen.', N'Nur Abfälle, die die Umwelt nicht gefährden, dürfen 300 m vom Ufer ins Wasser eingeleitet werden.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (216, N'Was ist beim Neuanstrich des Unterwasserschiffs und bei der Entfernung des alten Anstrichs zu beachten?', N'Es sind bei Arbeiten mit Unterwasseranstrichen die Richtlinien der Schiffsuntersuchungskommission zu beachten.', N'Es dürfen nur Unterwasseranstriche verwendet werden, deren Umweltverträglichkeit an der EU-Kennzeichnung erkenntlich ist.', N'Unterwasserarbeiten dürfen nur von zertifizierten Fachbetrieben, nach den Bestimmungen des Umweltschutzes ausgeführt werden.', N'Der Arbeitsbereich ist großzügig abzudecken und der anfallende Abfall ist als Sondermüll zu behandeln und entsprechend zu entsorgen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (217, N'Was ist bei Sturmwarnung vom Schiffsführer eines Sportbootes unter Segel auf einem größeren Gewässer zu veranlassen? ', N'Rettungsweste anlegen. Segel setzen, versuchen die Gewässermitte anzulaufen.', N'Rettungsweste anlegen. Segel bergen, versuchen einen Hafen oder eine geschützte Bucht anzulaufen.', N'Rettungsweste bereit halten. Segel bergen, versuchen, einen Hafen oder eine geschützte Bucht anzulaufen.', N'Rettungsweste anlegen. Alle Segel setzen, versuchen, einen Hafen oder eine geschützte Bucht anzulaufen.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (218, N'Welche Fahrrinnenseite hat ein Talfahrer an seiner Backbordseite? ', N'Die linke Fahrrinnenseite, gekennzeichnet durch rote Stumpftonnen oder Schwimmstangen.', N'Die rechte Fahrrinnenseite, gekennzeichnet durch grüne Spitztonnen oder Schwimmstangen.', N'Die linke Fahrrinnenseite, gekennzeichnet durch grüne Spitztonnen oder Schwimmstangen.', N'Die rechte Fahrrinnenseite, gekennzeichnet durch rote Stumpftonnen oder Schwimmstangen.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (219, N'Mit welcher Wetterentwicklung ist bei schnellem und stetig fallendem Luftdruck zu rechnen?', N'Besseres Wetter, Sonne.', N'Schlechtes Wetter, Starkwind oder Sturm.', N'Schlechtes Wetter ist nicht zu erwarten.', N'Besseres Wetter, steigende Temperatur.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (220, N'Welches Wetter ist zu erwarten, wenn der Luftdruck langsam, aber stetig steigt?', N'Besseres Wetter, Sonne.', N'Schlechtes Wetter, Starkwind oder Sturm.', N'Schlechtes Wetter ist nicht zu erwarten.', N'Besseres Wetter, steigende Temperatur.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (221, N'Wo darf auf Binnenschifffahrtsstraßen Wasserski gelaufen werden?', N'Außerhalb der Fahrrinne.', N'Nur in durch Tafelzeichen freigegebenen Bereichen.', N'Außerhalb des Fahrwassers.', N'Überall, ohne die Schifffahrt zu gefährden.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (222, N'Zu welcher Tageszeit und bei welchen Sichtweiten darf auf den erlaubten Gewässerabschnitten Wasserski gelaufen werden?', N'Sonnenaufgang bis ? untergang, Sicht 300 m und mehr.', N'Sonnenaufgang bis ? untergang, Sicht 500 m und mehr.', N'Sonnenaufgang bis ? untergang, Sicht 1500 m und mehr.', N'Sonnenaufgang bis ? untergang, Sicht 1000 m und mehr.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (223, N'Wie muss sich der Wasserskiläufer bei der Vorbeifahrt an Fahrzeugen, Schwimmkörpern oder Badenden verhalten?', N'Er darf bis zu 10 m beiderseits außerhalb des Kielwassers fahren.', N'Er muss im Kielwasser des Zugbootes bleiben.', N'Er darf bis zu 5 m beiderseits außerhalb des Kielwassers fahren.', N'Er muss uferseitig des Kielwassers fahren.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (224, N'Unter welchen Voraussetzungen darf außerhalb der ausgewiesenen Strecken/Wasserflächen Wassermotorrad gefahren werden?', N'Wenn kein anderer Verkehrsteilnehmer behindert wird.', N'Bei Touren- und Wanderfahrten mit klarem Geradeauskurs.', N'Ab Hochwassermarke I nur im Fahrwasser.', N'Bei großen Sonderveranstaltungen außerhalb der Fahrrinne.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (225, N'Wie hat sich der Führer eines Wassermotorrades außerhalb der ausgewiesenen Strecken/Wasserflächen zu verhalten?', N'Am Rande der Fahrrinne fahren.', N'Im Abstand von 10 m zum Ufer fahren.', N'Klaren Geradeauskurs fahren.', N'Im Abstand von 10 m außerhalb des Tonnenstrichs fahren.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (226, N'Auf welchen Gewässern ist die Fahrerlaubnis für Sportboote unter Segeln erforderlich?', N'Auf bestimmten Wasserstraßen in Berlin und Brandenburg.', N'Auf allen Landesgewässern.', N'Auf allen deutschen Wasserstraßen.', N'Auf den Binnenschifffahrtsstraßen und allen Landesgewässern.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (227, N'Weshalb muss sich der Schiffsführer vor dem Befahren fremder Gewässer über die dort geltenden Vorschriften informieren?', N'Um die jeweils geltenden Vorschriften einhalten zu können.', N'Weil die jeweils geltenden Vorschriften wichtige Informationen über die Brückendurchfahrtshöhen enthalten.', N'Da diese auf Landesgewässern grundsätzlich inhaltlich abweichen.', N'Da diese auf Bundesgewässern grundsätzlich inhaltlich abweichen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (228, N'Welcher Befähigungsnachweis berechtigt zum Führen eines Sportbootes mit einer Länge von 15 m bis 25 m auf dem Rhein?', N'Das Sportschifferzeugnis.', N'Der Sportbootführerschein See.', N'Der Sportbootführerschein Binnen.', N'Das Sportpatent.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (229, N'Welcher Befähigungsnachweis berechtigt zum Führen eines Sportbootes mit einer Länge von 15 m bis 25 m auf den Binnenschifffahrtsstraßen?', N'Der Sportbootführerschein Binnen.', N'Das Sportschifferzeugnis oder das Sportpatent.', N'Der Sportbootführerschein See.', N'Der Sportbootführerschein Binnen oder das Sportpatent.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (230, N'Wo sind umfangreiche Hinweise auf die Binnenschifffahrtsstraßen und deren Grenzen zu finden?', N'In der Binnenschiffsuntersuchungsordnung.', N'Im Teil I der Binnenschifffahrtsstraßen-Ordnung.', N'In der Kleinfahrzeugkennzeichenverordnung.', N'Im Teil II der Binnenschifffahrtsstraßen-Ordnung.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (231, N'Was ist bei der Ausübung des Wassersports auf Gewässern außerhalb der Bundeswasserstraßen (Landeswasserstraßen, kommunale und private Gewässer) zu beachten?', N'Es ist immer die Genehmigung des Wasser- und Schifffahrtsamtes einzuholen sowie die jeweilige Befahrensordnung zu beachten.', N'Es ist immer die Genehmigung des Eigentümers einzuholen sowie die jeweilige Befahrensordnung zu beachten.', N'Es ist gegebenenfalls die Genehmigung des Eigentümers einzuholen sowie die jeweilige Befahrensordnung zu beachten.', N'Es ist gegebenenfalls die Genehmigung des Eigentümers einzuholen sowie die Binnenschifffahrtsstraßenordnung zu beachten.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (232, N'Welche Kennzeichnungsarten für Sportboote gibt es?', N'Amtliche Kennzeichen und amtlich anerkannte Kennzeichen.', N'Kennzeichen gemäß Konformitätserklärung (CE-Zeichen).', N'Nur amtliche Kennzeichen.', N'Nur amtlich anerkannte Kennzeichen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (233, N'Welche Stelle ist für die Zuteilung eines amtlichen Kennzeichens für Sportboote zuständig?', N'Jedes Wasser- und Schifffahrtsamt.', N'Der Deutsche Motoryachtverband.', N'Der Deutsche Seglerverband.', N'Der Allgemeine Deutsche Automobilclub.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (234, N'Woraus bestehen die amtlich anerkannten Kennzeichen?', N'Nummer des Binnenschiffsregisters, gefolgt vom Kennbuchstaben für die ausstellende Organisation.', N'Die europäische Schiffsnummer, gefolgt vom Kennbuchstaben für die ausstellende Organisation.', N'Nummer des Seeschiffsregisters, gefolgt vom Kennbuchstaben für die ausstellende Organisation.', N'Nummer des Internationalen Bootsscheins, gefolgt vom Kennbuchstaben für die ausstellende Organisation.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (235, N'Welche Stellen sind für die Zuteilung eines amtlich anerkannten Kennzeichens zuständig?', N'Die Wasserschutzpolizei.', N'Amtsgerichte, bei denen ein Schiffsregister geführt wird.', N'Die Wasser- und Schifffahrtsämter.', N'Der Deutsche Motoryachtverband, der Deutsche Seglerverband, der Allgemeine Deutsche Automobilclub.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (236, N'Wann muss ein Wassersportfahrzeug in das Binnenschiffsregister eingetragen werden?', N'Ab 10 cbm Wasserverdrängung.', N'Ab 10 m Schiffslänge.', N'Ab 15 m Schiffslänge.', N'Ab 15 cbm Wasserverdrängung.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (237, N'Wie hat sich ein Schiffsführer bei Hochwasser zu verhalten?', N'Er muss die Geschwindigkeit anpassen und soweit wie möglich in der Fahrwassermitte bleiben, besondere Geschwindigkeitsbegrenzungen und Fahrtbeschränkungen sind nicht zu beachten.', N'Er muss die Geschwindigkeit anpassen und soweit wie möglich in seiner Fahrtrichtung rechts fahren, gegebenenfalls besondere Geschwindigkeitsbegrenzungen und Fahrtbeschränkungen beachten.', N'Er muss die Geschwindigkeit anpassen und soweit wie möglich in der Fahrwassermitte bleiben, gegebenenfalls besondere Geschwindigkeitsbegrenzungen und Fahrtbeschränkungen beachten.', N'Er muss die Geschwindigkeit anpassen und soweit wie möglich in seiner Fahrtrichtung links fahren, gegebenenfalls besondere Geschwindigkeitsbegrenzungen und Fahrtbeschränkungen beachten.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (238, N'Wie hat sich ein Schiffsführer bei Erreichen der Hochwassermarke II zu verhalten?', N'Er hat das Verbot der Schifffahrt bei Nacht zu beachten.', N'Er hat die Fahrt unverzüglich einzustellen.', N'Er hat die Geschwindigkeit anzupassen.', N'Er hat das Fahrverbot für Fahrzeuge ohne Sprechfunk zu beachten.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (239, N'Ein Fahrzeug fährt zu Tal. Voraus liegt eine rote Tonne. Auf welcher Fahrrinnenseite befindet sich diese Tonne und an welcher Schiffsseite muss diese Tonne passiert werden?', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Backbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an Backbordseite des Schiffes passiert werden.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (240, N'Ein Fahrzeug fährt zu Berg. Voraus liegt eine rote Tonne. Auf welcher Fahrrinnenseite befindet sich diese Tonne und an welcher Schiffsseite muss diese Tonne passiert werden?', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an der Backbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Backbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (241, N'Ein Fahrzeug fährt in der Fahrrinne gegen den Strom. Voraus liegt eine grüne Tonne. Auf welcher Fahrrinnenseite befindet sich diese Tonne und an welcher Schiffsseite muss diese Tonne passiert werden?', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der rechten Fahrrinnenseite und muss an der Backbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an der Steuerbordseite des Schiffes passiert werden.', N'Sie befindet sich auf der linken Fahrrinnenseite und muss an der Backbordseite des Schiffes passiert werden.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (242, N'Welche Funktion haben gelbe Tonnen mit einem Radarreflektor vor Brückenpfeiler? ', N'Kenntlichmachung einer gesperrten Brückendurchfahrt.', N'Kenntlichmachung der Brückenpfeiler auf dem Radarschirm.', N'Kenntlichmachung einer Untiefe im Brückenbereich.', N'Kenntlichmachung der Höhe der Brückenpfeiler.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (243, N'Welche Bedeutung haben diese Tafeln an der nachstehenden gekennzeichneten Brücke? {Binnen243.gif}', N'Empfohlene Durchfahrt ohne Gegenverkehr und seitlicher Begrenzung der erlaubten Brückendurchfahrt.', N'Empfohlene Durchfahrt mit Gegenverkehr ohne seitliche Begrenzung der erlaubten Brückendurchfahrt.', N'Vorgeschriebene Durchfahrt mit Gegenverkehr und seitlicher Begrenzung der erlaubten Brückendurchfahrt.', N'Empfohlene Durchfahrt mit Gegenverkehr und seitlicher Begrenzung der erlaubten Brückendurchfahrt.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (244, N'Was bedeutet dieses Tafelzeichen an einer Brückendurchfahrt? {Binnen244.gif}', N'Verbot der Durchfahrt und Sperrung der Schifffahrt.', N'Schutzbedürftige Anlage.', N'Gesperrte Durchfahrt, jedoch für Kleinfahrzeuge ohne Antriebsmaschine befahrbar.', N'Gesperrte Durchfahrt, jedoch für Kleinfahrzeuge mit Antriebsmaschine befahrbar.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (245, N'Warum ist es bei der Schleusendurchfahrt verboten, Autoreifen als Fender zu benutzen?', N'Autoreifen sind nicht schwimmfähig und können in den Schleusen zu erheblichen Störungen führen.', N'Autoreifen erzeugen eine zu hohe Reibung.', N'Autoreifen erzeugen schwarze Farbspuren am Boot und an der Schleusenmauer.', N'Autoreifen sind schwimmfähig und können in der Schleuse zu erheblichen Störungen führen.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (246, N'Welche Lichter führt ein Schubverband?', N'Drei weiße Topplichter in einem Dreieck angebracht, die Seitenlichter und zwei weiße Hecklichter waagerecht nebeneinander.', N'Drei weiße Topplichter in einem Dreieck angebracht, die Seitenlichter und drei weiße Hecklichter waagerecht nebeneinander.', N'Drei weiße Topplichter senkrecht untereinander angebracht, die Seitenlichter und drei weiße Hecklichter waagerecht nebeneinander.', N'Drei weiße Topplichter waagerecht nebeneinander, die Seitenlichter und drei weiße Hecklichter waagerecht nebeneinander.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (247, N'Welches Fahrzeug führt am Bug einen roten Wimpel?', N'Ein Fahrzeug mit Vorrang beim Be- und Entladen.', N'Ein Fahrzeug, das brennbare Stoffe geladen hat.', N'Ein Fahrzeug, das explosive Stoffe geladen hat.', N'Ein Fahrzeug mit Vorrang beim Schleusen.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (248, N'Wann gilt ein Sportboot auf den Binnenschifffahrtsstraßen als Kleinfahrzeug?', N'Wenn das Fahrzeug eine Länge von weniger als 20 m hat.', N'Wenn das Fahrzeug eine Länge von 25 m hat.', N'Wenn das Fahrzeug eine Länge von mehr als 20 m hat.', N'Wenn das Fahrzeug eine Länge von 20 m hat.', 1)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (249, N'Welche Bedeutung hat die Bezeichnung eines Fahrzeuges mit einer rot-weißen Flagge und was ist zu beachten?', N'Schutzbedürftiges Fahrzeug, Geschwindigkeit beibehalten und Sog und Wellenschlag vermeiden.', N'Schutzbedürftiges Fahrzeug, Geschwindigkeit vermindern.', N'Schutzbedürftiges Fahrzeug, Sog und Wellenschlag vermeiden.', N'Schutzbedürftiges Fahrzeug, Geschwindigkeit vermindern und Sog und Wellenschlag vermeiden.', 4)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (250, N'Welches optische Zeichen kann am Tage anstelle von vier kurzen Tönen gegeben werden?', N'Eine rote Flagge im Kreis schwenken.', N'Eine rote Flagge zeigen.', N'Eine rote Flagge im unteren Halbkreis schwenken.', N'Eine rote Flagge im oberen Halbkreis schwenken.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (251, N'Welches optische Zeichen kann in der Nacht oder bei verminderter Sicht anstelle von vier kurzen Tönen gegeben werden?', N'Ein rotes Licht zeigen.', N'Ein rotes Licht im Kreis schwenken.', N'Ein rotes Licht im unteren Halbkreis schwenken.', N'Ein rotes Licht im oberen Halbkreis schwenken.', 3)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (252, N'Welcher Befähigungsnachweis ist zur Teilnahme am Binnenschifffahrtsfunk erforderlich?', N'Das SRC-Sprechfunkzeugnis für den Binnenschifffahrtsfunk.', N'Das UKW-Sprechfunkzeugnis für den Binnenschifffahrtsfunk.', N'Das CB-Sprechfunkzeugnis für den Binnenschifffahrtsfunk.', N'Das Seefunkzeugnis für den Binnenschifffahrtsfunk.', 2)
INSERT [dbo].[T_SBF_Binnen] ([P_Id], [Frage], [Antwort1], [Antwort2], [Antwort3], [Antwort4], [RichtigeAntwort]) VALUES (253, N'Was bedeutet Radarfahrt? ', N'Eine Fahrt am Tage mit Radar.', N'Eine Fahrt bei unsichtigem Wetter mit Radar.', N'Eine Fahrt bei Nacht mit Radar.', N'Eine Fahrt mit Radar.', 2)










INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (1, N'Exam 1 Thema        ', N'Description Thema 1                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (2, N'Exam 2 Thema        ', N'Description Thema 2                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (3, N'Exam 3 Thema        ', N'Description Thema 3                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (4, N'Exam 4 Thema        ', N'Description Thema 4                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (5, N'Exam 5 Thema        ', N'Description Thema 5                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (6, N'Exam 6 Thema        ', N'Description Thema 6                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (7, N'Exam 7 Thema        ', N'Description Thema 7                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (8, N'Exam 8 Thema        ', N'Description Thema 8                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (9, N'Exam 9 Thema        ', N'Description Thema 9                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (10, N'Exam 10 Thema       ', N'Description Thema 10                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (11, N'Exam 11 Thema       ', N'Description Thema 11                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (12, N'Exam 12 Thema       ', N'Description Thema 12                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (13, N'Exam 13 Thema       ', N'Description Thema 13                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (14, N'Exam 14 Thema       ', N'Description Thema 14                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (15, N'Exam 15 Thema       ', N'Description Thema 15                                                                                ')








INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 8)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 115)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 16)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 17)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 32)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 47)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 60)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 63)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 77)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 84)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 86)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 88)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 92)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 99)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 102)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 118)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 129)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 137)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 139)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 147)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 162)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 168)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 183)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 191)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 207)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 214)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 222)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 237)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 244)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (1, 251)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 7)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 15)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 27)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 39)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 48)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 67)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 71)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 83)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 87)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 88)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 90)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 98)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 101)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 106)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 111)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 117)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 121)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 130)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 146)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 162)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 176)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 192)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 206)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 210)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 221)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 231)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 236)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 248)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 253)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 6)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 18)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 31)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 37)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 40)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 53)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 61)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 73)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 86)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 89)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 101)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 104)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 106)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 116)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 122)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 125)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 130)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 145)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 160)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 175)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 177)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 185)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 190)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 205)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 220)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 240)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 242)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 243)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 249)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (3, 250)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 5)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 21)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 32)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 38)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 54)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 59)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 68)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 76)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 82)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 97)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 103)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 114)
GO
print 'Processed 100 total records'
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 117)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 120)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 127)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 133)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 136)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 144)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 159)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 164)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 174)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 188)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 204)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 219)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 225)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 227)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 228)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 234)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 238)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (4, 246)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 4)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 23)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 31)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 44)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 58)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 65)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 72)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 84)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 91)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 99)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 113)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 119)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 128)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 132)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 142)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 155)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 158)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 169)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 173)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 188)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 196)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 203)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 209)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 212)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 213)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 222)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 230)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 233)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 248)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (5, 79)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 3)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 8)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 24)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 41)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 49)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 62)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 70)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 83)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 98)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 113)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 127)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 138)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 143)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 147)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 151)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 157)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 163)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 172)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 177)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 180)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 187)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 197)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 198)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 202)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 217)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 219)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 223)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 232)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 247)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (6, 195)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 2)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 7)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 25)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 42)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 45)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 59)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 69)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 75)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 82)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 97)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 111)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 126)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 134)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 141)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 156)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 157)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 158)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 160)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 166)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 171)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 182)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 186)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 194)
GO
print 'Processed 200 total records'
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 201)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 204)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 206)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 216)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 224)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 231)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (7, 246)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (2, 241)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 1)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 26)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 35)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 42)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 55)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 64)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 70)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 81)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 96)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 108)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 110)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 116)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 125)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 140)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 149)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 155)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 165)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 169)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 170)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 175)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 179)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 181)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 185)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 189)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 193)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 200)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 203)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 215)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 226)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (8, 245)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 3)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 15)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 27)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 38)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 43)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 48)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 50)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 80)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 85)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 95)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 109)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 124)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 139)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 150)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 154)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 156)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 167)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 174)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 176)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 181)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 184)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 187)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 190)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 192)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 196)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 208)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 213)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 229)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 236)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (9, 249)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 14)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 27)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 28)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 39)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 51)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 67)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 71)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 79)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 94)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 108)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 123)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 135)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 138)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 153)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 159)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 161)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 168)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 172)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 173)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 183)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 189)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 198)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 199)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 207)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 211)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 221)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 228)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 235)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 243)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (10, 252)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 9)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 13)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 30)
GO
print 'Processed 300 total records'
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 40)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 50)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 57)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 64)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 78)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 93)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 107)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 122)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 129)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 137)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 144)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 152)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 167)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 171)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 182)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 197)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 202)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 205)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 212)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 218)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 220)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 222)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 227)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 234)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 242)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 251)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 2)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 12)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 29)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 36)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 44)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 52)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 72)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 77)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 92)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 100)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 105)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 112)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 121)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 123)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 124)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 131)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 136)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 141)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 143)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 151)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 166)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 181)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 199)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 211)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 216)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 226)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 241)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 245)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 250)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 11)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 16)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 22)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 34)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 46)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 56)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 65)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 74)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 91)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 102)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 105)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 107)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 114)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 120)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 128)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 135)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 150)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 161)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 165)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 172)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 180)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 195)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 200)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 210)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 218)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 225)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 233)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 240)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 247)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (13, 252)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 10)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 15)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 20)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 33)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 46)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 68)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 72)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 73)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 75)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 90)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 94)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 100)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 104)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 109)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 126)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 132)
GO
print 'Processed 400 total records'
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 134)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 136)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 141)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 149)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 164)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 179)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 194)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 209)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 215)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 224)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 229)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 235)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 237)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (14, 239)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 1)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 9)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 19)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 31)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 45)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 53)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 66)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 74)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 76)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 78)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 81)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 87)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 89)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 95)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 103)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 118)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 125)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 131)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 133)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 148)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 163)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 175)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 178)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 193)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 201)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 208)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 223)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 230)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 238)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (15, 253)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (11, 217)
INSERT [dbo].[T_Fragebogen_unter_Maschine] ([FragebogenNr], [F_Id_SBF_Binnen]) VALUES (12, 232)








/****** Object:  View [dbo].[View_Topics_And_Questions]    Script Date: 03/22/2017 14:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Topics_And_Questions]
AS
SELECT     dbo.T_SBF_Binnen.P_Id, dbo.T_SBF_Binnen.Frage, dbo.T_SBF_Binnen.Antwort1, dbo.T_SBF_Binnen.Antwort2, dbo.T_SBF_Binnen.Antwort3, dbo.T_SBF_Binnen.Antwort4, 
                      dbo.T_Fragebogen_unter_Maschine.FragebogenNr, dbo.T_SBF_Binnen.RichtigeAntwort
FROM         dbo.T_Fragebogen_unter_Maschine INNER JOIN
                      dbo.T_SBF_Binnen ON dbo.T_Fragebogen_unter_Maschine.F_Id_SBF_Binnen = dbo.T_SBF_Binnen.P_Id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_Fragebogen_unter_Maschine"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 96
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_SBF_Binnen"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 126
               Right = 415
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Topics_And_Questions'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Topics_And_Questions'
GO