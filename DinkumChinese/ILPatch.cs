using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace DinkumChinese
{
    public static class ILPatch
    {
        [HarmonyTranspiler, HarmonyPatch(typeof(AnimalHouseMenu), "fillData")]
        public static IEnumerable<CodeInstruction> AnimalHouseMenu_fillData_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " Year", " Jahr");
            instructions = ReplaceIL(instructions, " Month", " Monat");
            instructions = ReplaceIL(instructions, " Day", " Tag");
            instructions = ReplaceIL(instructions, "s", "");
            instructions = ReplaceIL(instructions, "SELL ", "verkaufe ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(AnimalHouseMenu), "openConfirm")]
        public static IEnumerable<CodeInstruction> AnimalHouseMenu_openConfirm_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Sell ", "Verkaufe ");
            instructions = ReplaceIL(instructions, " for <sprite=11>", " für <sprite=11>");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BankMenu), "convertButton")]
        public static IEnumerable<CodeInstruction> BankMenu_convertButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Convert [<sprite=11> 500 for <sprite=15> 1]", "Tausche [<sprite=11> 500 für <sprite=15> 1]");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BankMenu), "depositButton")]
        public static IEnumerable<CodeInstruction> BankMenu_depositButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Deposit", "Einzahlen");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BankMenu), "open")]
        public static IEnumerable<CodeInstruction> BankMenu_open_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Account Balance", "Kontostand");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BankMenu), "openAsDonations")]
        public static IEnumerable<CodeInstruction> BankMenu_openAsDonations_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Town Debt", "Stadtschulden");
            instructions = ReplaceIL(instructions, "Donate", "spenden");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BankMenu), "withdrawButton")]
        public static IEnumerable<CodeInstruction> BankMenu_withdrawButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Withdraw", "Abheben");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BugAndFishCelebration), "openWindow")]
        public static IEnumerable<CodeInstruction> BugAndFishCelebration_openWindow_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "I caught a ", "Ich habe gefangen: ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BulletinBoard), "getMissionText")]
        public static IEnumerable<CodeInstruction> BulletinBoard_getMissionText_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<sprite=12> Trade ", "<sprite=12> tauschen");
            instructions = ReplaceIL(instructions, " with ", "mit");
            instructions = ReplaceIL(instructions, "<sprite=12> Speak to ", "Spreche mit <sprite=12>");
            instructions = ReplaceIL(instructions, "<sprite=12> Hunt down the ", "Jage ein <sprite=12>");
            instructions = ReplaceIL(instructions, " using its last know location on the map", "mithilfe der letzten bekannten Position auf der Karte");
            instructions = ReplaceIL(instructions, "<sprite=13> Visit the location on the map to investigate", "<sprite=13> Besuche die Position auf der Karte um zu erforschen");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BulletinBoard), "showSelectedPost")]
        public static IEnumerable<CodeInstruction> BulletinBoard_showSelectedPost_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "EXPIRED", "abgelaufen");
            instructions = ReplaceIL(instructions, " Last Day", " letzter Tag");
            instructions = ReplaceIL(instructions, " Days Remaining", " Tage verbleiben");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(BullitenBoardPost), "getBoardRequestItem")]
        public static IEnumerable<CodeInstruction> BullitenBoardPost_getBoardRequestItem_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "any other furniture", "irgendein Möbelstück");
            instructions = ReplaceIL(instructions, "any other clothing", "irgendein Kleidungsstück");
            return instructions;
        }

        // todo
        [HarmonyTranspiler, HarmonyPatch(typeof(CameraController), "moveCameraToShowPos", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> CameraController_moveCameraToShowPos_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " is visiting the island!", " besucht die Insel");
            instructions = ReplaceIL(instructions, "Someone is visiting the island!", "Jemand besucht die Insel！");
            instructions = ReplaceIL(instructions, "No one is visiting today...", "Keine Besucher heute...");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(ConversationManager), "checkLineForReplacement")]
        public static IEnumerable<CodeInstruction> ConversationManager_checkLineForReplacement_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "South City", "Südstadt");
            instructions = ReplaceIL(instructions, "Journal", "Logbuch");
            instructions = ReplaceIL(instructions, "Licence", "Lizenz");
            instructions = ReplaceIL(instructions, "Licences", "Lizenzen");
            instructions = ReplaceIL(instructions, "Airship", "Luftschiff");
            instructions = ReplaceIL(instructions, "Nomad", "Nomade");
            instructions = ReplaceIL(instructions, "Nomads", "Nomaden");
            instructions = ReplaceIL(instructions, "I just love the colours!", "Ich mag die Farben einfach!");
            instructions = ReplaceIL(instructions, "I love this one.", "Das mag ich gern.");
            instructions = ReplaceIL(instructions, "The composition is wonderful", "Die Komposition ist wundervoll!");
            instructions = ReplaceIL(instructions, "It speaks to me, you know?", "Das spricht mich an.");
            instructions = ReplaceIL(instructions, "It makes me feel something...", "Es lässt mich etwas fühlen...");
            instructions = ReplaceIL(instructions, "Made by hand by yours truly!", "Von Hand gefertigt von mir！");
            instructions = ReplaceIL(instructions, "Finished that one off today!", "Das ist heute erst fertig geworden!");
            instructions = ReplaceIL(instructions, "It feels just right for you, ", "Das fühlt sich genau nach etwas für dich an, ");
            instructions = ReplaceIL(instructions, "The colour is very powerful, y'know?", "Die Farbe ist sehr kräftig, findest du nich auch?");
            instructions = ReplaceIL(instructions, "It will open your chakras, y'know?", "Es wird deine Chakren öffnen, glaub mir.");
            instructions = ReplaceIL(instructions, "Do you feel the engery coming from it?", "Fühlst du die Energie die davon ausgeht?");
            instructions = ReplaceIL(instructions, "I feel good things coming to whoever buys it.", "Ich spüre wie es seinem Käufer Glück bringen wird.");
            instructions = ReplaceIL(instructions, "The design just came to me, y'know?", "Das Design ist mir gerade eingefallen, einfach so.");
            instructions = ReplaceIL(instructions, "Y'know, that would look great on you, ", "Ich glaube das wird gut an dir aussehen, ");
            instructions = ReplaceIL(instructions, "I put a lot of myself into this one.", "Ich habe viel von mir selbst in das hier gesteckt.");
            instructions = ReplaceIL(instructions, "Beginning...", "Anfangen...");
            instructions = ReplaceIL(instructions, "...Nothing happened...", "...nichts passiert...");
            instructions = ReplaceIL(instructions, "Permit Points", "Zulassungspunkte");
            instructions = ReplaceIL(instructions, "s", "s");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(ConversationManager), "talkToNPC")]
        public static IEnumerable<CodeInstruction> ConversationManager_talkToNPC_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "A new deed is available!", "Ein neues Bauvorhaben ist verfügbar!");
            instructions = ReplaceIL(instructions, "Talk to Fletch to apply for deeds.", "Sprich mit Fletch, um Bauvorhaben zu beantragen.");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(CraftingManager), "populateCraftList")]
        public static IEnumerable<CodeInstruction> CraftingManager_populateCraftList_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "COOK", "<color=#F87474>kochen</color>");
            instructions = ReplaceIL(instructions, "COOKING", "kocht");
            instructions = ReplaceIL(instructions, "COMMISSION", "<color=#F87474>beauftragen</color>");
            instructions = ReplaceIL(instructions, "CRAFTING", "wird hergestellt");
            instructions = ReplaceIL(instructions, "CRAFT", "<color=#F87474>herstellen</color>");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(EquipItemToChar), "OnDestroy")]
        public static IEnumerable<CodeInstruction> EquipItemToChar_OnDestroy_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " has left", " hat die Insel verlassen");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(EquipItemToChar), "UserCode_RpcCharacterJoinedPopup")]
        public static IEnumerable<CodeInstruction> EquipItemToChar_UserCode_RpcCharacterJoinedPopup_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Welcome to ", "Willkommen auf");
            instructions = ReplaceIL(instructions, " has joined", " hat die Insel betreten");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(ExhibitSign), "Start")]
        public static IEnumerable<CodeInstruction> ExhibitSign_Start_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "This exhibit is currently empty.", "Die Ausstellung ist im Moment leer.");
            instructions = ReplaceIL(instructions, "We look forward to future donations!", "Wir freuen uns auf zukünftige Spenden！");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(ExhibitSign), "updateMySign")]
        public static IEnumerable<CodeInstruction> ExhibitSign_updateMySign_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "In this exhibit:", "In dieser Ausstellung:");
            return instructions;
        }

        // todo
        [HarmonyTranspiler, HarmonyPatch(typeof(FadeBlackness), "fadeInDateText", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> FadeBlackness_fadeInDateText_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Year ", "Jahr ");
            return instructions;
        }

        // todo
        [HarmonyTranspiler, HarmonyPatch(typeof(GiftedItemWindow), "giveItemDelay", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> GiftedItemWindow_giveItemDelay_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "New Licence!", "Neue Lizenz！");
            instructions = ReplaceIL(instructions, " Level ", " Level ");
            instructions = ReplaceIL(instructions, "On ya!", "Gut gemacht！");
            instructions = ReplaceIL(instructions, "You received", "Du hast erhalten: ");
            instructions = ReplaceIL(instructions, "New Crafting Recipe", "Neues Bastel-Rezept");
            instructions = ReplaceIL(instructions, "An item was sent to your Mailbox", "Ein Item wurde mit der Post an dich geschickt");
            instructions = ReplaceIL(instructions, "Your pockets were full!", "Deine Taschen sind voll！");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(GiveNPC), "UpdateMenu", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> GiveNPC_UpdateMenu_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Place", "Platzieren");
            instructions = ReplaceIL(instructions, "Donate", "Spenden");
            instructions = ReplaceIL(instructions, "Sell", "Verkaufen");
            instructions = ReplaceIL(instructions, "Cancel", "Abbrechen");
            instructions = ReplaceIL(instructions, "Swap", "Tauschen");
            instructions = ReplaceIL(instructions, "Give", "Geben");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(InventoryItemDescription), "fillItemDescription")]
        public static IEnumerable<CodeInstruction> InventoryItemDescription_fillItemDescription_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "All year", "ganzjährlich");
            instructions = ReplaceIL(instructions, "Summer", "Sommer");
            instructions = ReplaceIL(instructions, "Autum", "Herbst");
            instructions = ReplaceIL(instructions, "Winter", "Winter");
            instructions = ReplaceIL(instructions, "Spring", "Frühling");
            instructions = ReplaceIL(instructions, "Bury", "Vergraben");
            instructions = ReplaceIL(instructions, "Speeds up certain production devices for up to 12 tiles", "Beschleunigt bestimmte Produktionsgeräte im Umkreis von 12 Feldern");
            instructions = ReplaceIL(instructions, "Reaches ", "Erreicht");
            instructions = ReplaceIL(instructions, " tiles out.\n<color=red>Requires Water Tank</color>", "Felder.\n<color=red>Benötigt einen Wassertank</color>");
            instructions = ReplaceIL(instructions, "Provides water to sprinklers ", "Versorgt Sprinkler mit Wasser.");
            instructions = ReplaceIL(instructions, " tiles out.", "Sprinkler innerhalb eines Blockradius liefern Wasser");
            instructions = ReplaceIL(instructions, "Fills animal feeders ", "Befüllt Futtertröge.");
            instructions = ReplaceIL(instructions, " tiles out.\n<color=red>Requires Animal Food</color>", "Felder.\n<color=red>Benötigt Tierfutter.</color>");

            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(InventoryLootTableTimeWeatherMaster), "getTimeOfDayFound")]
        public static IEnumerable<CodeInstruction> InventoryLootTableTimeWeatherMaster_getTimeOfDayFound_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "all day", "ganztägig");
            instructions = ReplaceIL(instructions, "during the day", "tagsüber");
            instructions = ReplaceIL(instructions, "early mornings", "früher Morgen");
            instructions = ReplaceIL(instructions, "around noon", "um die Mittagszeit");
            instructions = ReplaceIL(instructions, "after dark", "nach Sonnenuntergang");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(LicenceButton), "fillButton")]
        public static IEnumerable<CodeInstruction> LicenceButton_fillButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Level ", "Level");
            instructions = ReplaceIL(instructions, "Level up your ", "Verbessere dein Level in");
            instructions = ReplaceIL(instructions, " skill to unlock further levels", "Fähigkeit, um mehr Level freizuschalten");
            instructions = ReplaceIL(instructions, "Max Level", "Maximales Level");
            instructions = ReplaceIL(instructions, "Not Held", "besitzt du nicht");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(LicenceButton), "fillDetailsForJournal")]
        public static IEnumerable<CodeInstruction> LicenceButton_fillDetailsForJournal_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Level ", "Level");
            instructions = ReplaceIL(instructions, "Max Level", "Maximales Level");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(LicenceManager), "checkForUnlocksOnLevelUp")]
        public static IEnumerable<CodeInstruction> LicenceManager_checkForUnlocksOnLevelUp_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "A new Licence is available!", "Eine neue Lizenz ist verfügbar！");
            instructions = ReplaceIL(instructions, "A new deed is available!", "Ein neues Bauvorhaben ist verfügbar！");
            instructions = ReplaceIL(instructions, "Talk to Fletch to apply for deeds.", "Sprich mit Fletch, um Bauvorhaben zu beantragen.");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(LicenceManager), "getLicenceLevelDescription")]
        public static IEnumerable<CodeInstruction> LicenceManager_getLicenceLevelDescription_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Coming soon. The holder will get instant access to Building Level 3 once it has arrived",
                "Wird noch programmiert: Der Halter dieser Lizenz wird sofort Zugriff auf Bauen Level 3 bekommen sobald es programmiert wurde");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(LicenceManager), "openConfirmWindow")]
        public static IEnumerable<CodeInstruction> LicenceManager_openConfirmWindow_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Level ", "Level");
            instructions = ReplaceIL(instructions, "You hold all ", "Du hast alles");
            instructions = ReplaceIL(instructions, " levels", "Level");
            instructions = ReplaceIL(instructions, "Level up your ", "Verbessere dein Level in");
            instructions = ReplaceIL(instructions, " skill to unlock further levels", "Fähigkeit, um mehr Level freizuschalten");
            instructions = ReplaceIL(instructions, "You hold all current ", "du besitzt alle ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(MailManager), "getSentByName")]
        public static IEnumerable<CodeInstruction> MailManager_getSentByName_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Animal Research Centre", "Tierforschungszentrum");
            instructions = ReplaceIL(instructions, "Dinkum Dev", "Dinkum Entwickler");
            instructions = ReplaceIL(instructions, "Fishin' Tipster", "Fisch Tippgeber");
            instructions = ReplaceIL(instructions, "Bug Tipster", "Insekten Tippgeber");
            instructions = ReplaceIL(instructions, "Unknown", "Unbekannt");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(MailManager), "showLetter")]
        public static IEnumerable<CodeInstruction> MailManager_showLetter_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "From ", "Von");
            instructions = ReplaceIL(instructions, "<size=18><b>To ", "<size=18><b>An");
            instructions = ReplaceIL(instructions, "\n\n<size=18><b>From ", "\n\n<size=18><b>Von");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NetworkMapSharer), "UserCode_RpcAddToMuseum")]
        public static IEnumerable<CodeInstruction> NetworkMapSharer_UserCode_RpcAddToMuseum_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Donated by ", "Gespendet von: ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NetworkMapSharer), "UserCode_RpcPayTownDebt")]
        public static IEnumerable<CodeInstruction> NetworkMapSharer_UserCode_RpcPayTownDebt_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " donated <sprite=11>", "spendete <sprite=11>");
            instructions = ReplaceIL(instructions, " towards town debt", " um die Stadtschulden zu tilgen");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NetworkNavMesh), "onSleepingAmountChange")]
        public static IEnumerable<CodeInstruction> NetworkNavMesh_onSleepingAmountChange_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<b><color=purple> Sleeping </color></b>", "<b><color=purple> schlafen... </color></b>");
            instructions = ReplaceIL(instructions, "<b><color=purple> Ready to Sleep </color></b> [", "<b><color=purple> bereit zum Schlafen </color></b> [");
            return instructions;
        }

        // todo
        [HarmonyTranspiler, HarmonyPatch(typeof(NetworkNavMesh), "waitForNameToChange", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> NetworkNavMesh_waitForNameToChange_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " has joined", " hat die Insel betreten");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCRequest), "acceptRequest")]
        public static IEnumerable<CodeInstruction> NPCRequest_acceptRequest_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Request added to Journal", "Aufgabe zum Logbuch hinzugefügt");
            instructions = ReplaceIL(instructions, "This request must be completed by the end of the day.", "Diese Aufgabe muss heute noch erfüllt werden.");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCRequest), "getDesiredItemName")]
        public static IEnumerable<CodeInstruction> NPCRequest_getDesiredItemName_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "any bug", "irgendein Insekt");
            instructions = ReplaceIL(instructions, "any fish", "irgendein Fisch");
            instructions = ReplaceIL(instructions, "something to eat", "etwas zu essen");
            instructions = ReplaceIL(instructions, "something you've made me at a cooking table", "etwas das du mir am Kochtisch zubereitet hast");
            instructions = ReplaceIL(instructions, "furniture", "Möbel");
            instructions = ReplaceIL(instructions, "clothing", "Kleider");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCRequest), "getMissionText")]
        public static IEnumerable<CodeInstruction> NPCRequest_getMissionText_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<sprite=12> Bring ", "<sprite=12> Bringe");
            instructions = ReplaceIL(instructions, "<sprite=13> Collect ", "<sprite=13> Sammel ");
            instructions = ReplaceIL(instructions, "\n<sprite=12> Bring ", "\n<sprite=12> Bringe ");
            instructions = ReplaceIL(instructions, "<sprite=12> Collect ", "<sprite=12> Sammel ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCSchedual), "getDaysClosed")]
        public static IEnumerable<CodeInstruction> NPCSchedual_getDaysClosed_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Closed: ", "Geschlossen: ");
            instructions = ReplaceIL(instructions, " and ", " und ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCSchedual), "getNextDayOffName")]
        public static IEnumerable<CodeInstruction> NPCSchedual_getNextDayOffName_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "No Day off", "Immer geöffnet");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(NPCSchedual), "getOpeningHours")]
        public static IEnumerable<CodeInstruction> NPCSchedual_getOpeningHours_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Open: ", "Geöffnet: ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PlayerDetailManager), "switchToLevelWindow")]
        public static IEnumerable<CodeInstruction> PlayerDetailManager_switchToLevelWindow_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Resident for: ", "Bewohner seit:");
            instructions = ReplaceIL(instructions, " days", " Tagen");
            instructions = ReplaceIL(instructions, " months", " Monaten");
            instructions = ReplaceIL(instructions, " years", " Jahren");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PocketsFullNotification), "showMustBeEmpty")]
        public static IEnumerable<CodeInstruction> PocketsFullNotification_showMustBeEmpty_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Must be empty", "Muss leer sein");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PocketsFullNotification), "showNoLicence")]
        public static IEnumerable<CodeInstruction> PocketsFullNotification_showNoLicence_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Need Licence", "Lizenz benötigt");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PocketsFullNotification), "showPocketsFull")]
        public static IEnumerable<CodeInstruction> PocketsFullNotification_showPocketsFull_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Pockets Full", "Taschen sind voll");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PocketsFullNotification), "showTooFull")]
        public static IEnumerable<CodeInstruction> PocketsFullNotification_showTooFull_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Too full", "Nicht hungrig");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PostOnBoard), "acceptTask")]
        public static IEnumerable<CodeInstruction> PostOnBoard_acceptTask_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Request added to Journal by ", "Aufgabe zum Logbuch hinzugefügt von ");
            instructions = ReplaceIL(instructions, "Request added to Journal", "Aufgabe wurde zum Logbuch hinzugefügt");
            instructions = ReplaceIL(instructions, "A location was added to your map.", "Eine Markierung wurde deiner Karte hinzugefügt.");
            instructions = ReplaceIL(instructions, "This request has a time limit.", "Diese Aufgabe hat ein Zeitlimit.");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PostOnBoard), "completeTask")]
        public static IEnumerable<CodeInstruction> PostOnBoard_completeTask_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Request Completed by ", "Aufgabe erfüllt von ");
            instructions = ReplaceIL(instructions, "Investigation Request Complete!", "Erforschungsaufgabe beendet!");
            instructions = ReplaceIL(instructions, "Request Complete!", "Aufgabe beendet！");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(PostOnBoard), "getPostedByName")]
        public static IEnumerable<CodeInstruction> PostOnBoard_getPostedByName_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Town Announcement", "Stadtankündigung");
            instructions = ReplaceIL(instructions, "Animal Research Centre", "Tierforschungszentrum");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(Quest), "getMissionObjText")]
        public static IEnumerable<CodeInstruction> Quest_getMissionObjText_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<sprite=12> Attract a total of 5 permanent residents to move to ", "<sprite=12> Überzeuge 5 Leute einzuziehen auf ");
            instructions = ReplaceIL(instructions, "<sprite=12> Talk to ", "\n<sprite=12> Sprich mit");
            instructions = ReplaceIL(instructions, " once the Base Tent has been moved", " sobald das Basiszelt bewegt wurde");
            instructions = ReplaceIL(instructions, "<sprite=13> Craft a ", "<sprite=13> Stelle eine");
            instructions = ReplaceIL(instructions, "at the crafting table in the Base Tent.\n<sprite=13> Place the  ", "an der Werkbank im Basiszelt her.\n<sprite=13> Platziere ");
            instructions = ReplaceIL(instructions, " down outside.\n<sprite=13> Place Tin Ore into ", "draußen. \n<sprite=13> Platziere das Zinn-Erz in den");
            instructions = ReplaceIL(instructions, " and wait for it to become ", "und warte bis es geworden ist zu");
            instructions = ReplaceIL(instructions, ".\n<sprite=12> Take the ", ". \n<sprite=12> Nimm ");
            instructions = ReplaceIL(instructions, " to ", "zu");
            instructions = ReplaceIL(instructions, " down outside.\n<sprite=12> Place Tin Ore into ", "draußen. \n<sprite=12> Platziere das Zinn-Erz in den");
            instructions = ReplaceIL(instructions, "at the crafting table in the Base Tent.\n<sprite=12> Place the  ", "在基础帐篷的制作桌上。\n<sprite=12> 放置");
            instructions = ReplaceIL(instructions, "<sprite=12> Craft a ", "<sprite=12> 制作一个");
            instructions = ReplaceIL(instructions, "<sprite=13> Buy the ", "<sprite=13> 购买");
            instructions = ReplaceIL(instructions, "\n<sprite=12> Talk to ", "\n<sprite=12> 对话");
            instructions = ReplaceIL(instructions, "<sprite=12> Buy the ", "<sprite=12> 购买");
            instructions = ReplaceIL(instructions, "[Optional] Complete Daily tasks\n<sprite=12> Place sleeping bag and get some rest.", "[可选]完成日常任务\n<sprite=12>放置睡袋并休息。");
            instructions = ReplaceIL(instructions, "<sprite=13> Find something to eat.\n<sprite=12> Talk to ", "<sprite=13> 找点吃的。\n<sprite=12> 对话");
            instructions = ReplaceIL(instructions, "<sprite=12> Find something to eat.\n<sprite=12> Talk to ", "<sprite=12> 找点吃的。\n<sprite=12> 对话");
            instructions = ReplaceIL(instructions, "<sprite=13> Collect the requested items.\n<sprite=12> Bring items to ", "<sprite=13> 收集请求的物品。\n<sprite=12> 将物品带到");
            instructions = ReplaceIL(instructions, "<sprite=12> Collect the requested items.", "<sprite=12> 收集请求的物品。");
            instructions = ReplaceIL(instructions, "\n<sprite=12> Bring items to ", "\n<sprite=12> 将物品带到");
            instructions = ReplaceIL(instructions, "<sprite=12> Do some favours for John", "<sprite=12> 帮助John");
            instructions = ReplaceIL(instructions, "<sprite=13> Do some favours for John", "<sprite=13> 帮助John");
            instructions = ReplaceIL(instructions, "\n<sprite=12> Spend money or sell items in John's store", "\n<sprite=12> 在John的店里花钱或卖东西");
            instructions = ReplaceIL(instructions, "\n<sprite=13> Spend money or sell items in John's store", "\n<sprite=13> 在John的店里花钱或卖东西");
            instructions = ReplaceIL(instructions, "\n<sprite=12> Convince John to move in.", "\n<sprite=12> 说服John留下来。");
            instructions = ReplaceIL(instructions, "<sprite=12> Ask ", "<sprite=12> 询问");
            instructions = ReplaceIL(instructions, " about the town to apply for the ", "关于城镇申请");
            instructions = ReplaceIL(instructions, "<sprite=12> Place the ", "<sprite=12> 放置");
            instructions = ReplaceIL(instructions, "<sprite=12> Wait for construction of the  ", "<sprite=12> 等待");
            instructions = ReplaceIL(instructions, " to be completed", "的施工完成");
            instructions = ReplaceIL(instructions, "<sprite=12> Place the required items into the construction box at the deed site", "<sprite=12> 将所需物品放入契约现场的材料箱中");
            instructions = ReplaceIL(instructions, "<sprite=12> Place ", "<sprite=12> 放置");
            instructions = ReplaceIL(instructions, "<sprite=13> Place ", "<sprite=13> 放置");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestManager), "completeQuest")]
        public static IEnumerable<CodeInstruction> QuestManager_completeQuest_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "A new deed is available!", "新契约可用！");
            instructions = ReplaceIL(instructions, "Talk to Fletch to apply for deeds.", "与Fletch谈谈申请契约。");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "displayQuest")]
        public static IEnumerable<CodeInstruction> QuestTracker_displayQuest_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " days remaining", " 天剩余");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "displayRequest")]
        public static IEnumerable<CodeInstruction> QuestTracker_displayRequest_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Request for ", "请求 来自");
            instructions = ReplaceIL(instructions, " has asked you to get ", "想向你要");
            instructions = ReplaceIL(instructions, "By the end of the day", "在今天结束之前");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "displayTrackingRecipe")]
        public static IEnumerable<CodeInstruction> QuestTracker_displayTrackingRecipe_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " Recipe", " 配方");
            instructions = ReplaceIL(instructions, "These items are required to craft ", "制作");
            instructions = ReplaceIL(instructions, "\n Unpin this to stop tracking recipe.", "需要这些物品。\n取消固定来停止跟踪配方");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "fillMissionTextForRecipe")]
        public static IEnumerable<CodeInstruction> QuestTracker_fillMissionTextForRecipe_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Crafting ", "制作 ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "pressPinRecipeButton")]
        public static IEnumerable<CodeInstruction> QuestTracker_pressPinRecipeButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " Recipe", " 配方");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "updateLookingAtTask")]
        public static IEnumerable<CodeInstruction> QuestTracker_updateLookingAtTask_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<sprite=17> Pinned", "<sprite=17> 固定");
            instructions = ReplaceIL(instructions, "<sprite=16> Pinned", "<sprite=16> 固定");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "updatePinnedRecipeButton")]
        public static IEnumerable<CodeInstruction> QuestTracker_updatePinnedRecipeButton_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<sprite=13> Track Recipe Ingredients", "<sprite=13> 跟踪配方成分");
            instructions = ReplaceIL(instructions, "<sprite=12> Track Recipe Ingredients", "<sprite=12> 跟踪配方成分");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(QuestTracker), "updatePinnedTask")]
        public static IEnumerable<CodeInstruction> QuestTracker_updatePinnedTask_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Request for ", "请求 来自");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(RealWorldTimeLight), "showTimeOnClock")]
        public static IEnumerable<CodeInstruction> RealWorldTimeLight_showTimeOnClock_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "<size=10>PM</size>", "<size=10>下午</size>");
            instructions = ReplaceIL(instructions, "<size=10>AM</size>", "<size=10>上午</size>");
            instructions = ReplaceIL(instructions, "Late", "深夜");
            return instructions;
        }

        /// <summary>
        /// 在IL中替换文本
        /// </summary>
        public static IEnumerable<CodeInstruction> ReplaceIL(IEnumerable<CodeInstruction> instructions, string target, string i18n)
        {
            bool success = false;
            var list = instructions.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var ci = list[i];
                if (ci.opcode == OpCodes.Ldstr)
                {
                    if ((string)ci.operand == target)
                    {
                        ci.operand = i18n;
                        success = true;
                    }
                }
            }
            if (!success)
            {
                Debug.LogWarning($"汉化插件欲将{target}替换成{i18n}失败，没有找到目标");
            }
            return list.AsEnumerable();
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(SaveSlotButton), "fillFromSaveSlot")]
        public static IEnumerable<CodeInstruction> SaveSlotButton_fillFromSaveSlot_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Year ", "年份 ");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(SeasonAndTime), "getLocationName")]
        public static IEnumerable<CodeInstruction> SeasonAndTime_getLocationName_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Everywhere", "任意地点");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(Task), MethodType.Constructor, new Type[] { typeof(int), typeof(int) })]
        public static IEnumerable<CodeInstruction> Task_Constructor_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Harvest ", "收获");
            instructions = ReplaceIL(instructions, "Catch ", "捕捉");
            instructions = ReplaceIL(instructions, " Bugs", " 虫子");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(Task), "generateTask")]
        public static IEnumerable<CodeInstruction> Task_generateTask_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " ", "");
            instructions = ReplaceIL(instructions, "Harvest ", "收获");
            instructions = ReplaceIL(instructions, "Chat with ", "和");
            instructions = ReplaceIL(instructions, " residents", "居民聊天");
            instructions = ReplaceIL(instructions, "Bury ", "掩埋");
            instructions = ReplaceIL(instructions, " Fruit", "水果");
            instructions = ReplaceIL(instructions, "Collect ", "收集");
            instructions = ReplaceIL(instructions, " Shells", "贝壳");
            instructions = ReplaceIL(instructions, "Sell ", "出售");
            instructions = ReplaceIL(instructions, "Do a job for someone", "完成居民请求");
            instructions = ReplaceIL(instructions, "Plant ", "种植");
            instructions = ReplaceIL(instructions, " Wild Seeds", "野生种子");
            instructions = ReplaceIL(instructions, "Dig up dirt ", "铲土");
            instructions = ReplaceIL(instructions, " times", "次");
            instructions = ReplaceIL(instructions, "Catch ", "捕捉");
            instructions = ReplaceIL(instructions, " Bugs", "虫子");
            instructions = ReplaceIL(instructions, "Craft ", "制作");
            instructions = ReplaceIL(instructions, " Items", "物品");
            instructions = ReplaceIL(instructions, "Eat something", "吃点东西");
            instructions = ReplaceIL(instructions, "Make ", "获得");
            instructions = ReplaceIL(instructions, "Spend ", "花费");
            instructions = ReplaceIL(instructions, "Travel ", "旅行");
            instructions = ReplaceIL(instructions, "m on foot.", "米（徒步）");
            instructions = ReplaceIL(instructions, "m by vehicle", "米（载具）");
            instructions = ReplaceIL(instructions, "Cook ", "烤制");
            instructions = ReplaceIL(instructions, " meat", "肉");
            instructions = ReplaceIL(instructions, " fruit", "水果");
            instructions = ReplaceIL(instructions, "Cook something at the Cooking table", "烹饪食物");
            instructions = ReplaceIL(instructions, " tree seeds", "树种子");
            instructions = ReplaceIL(instructions, "crop seeds", "作物种子");
            instructions = ReplaceIL(instructions, "Water ", "浇灌");
            instructions = ReplaceIL(instructions, " crops", "作物");
            instructions = ReplaceIL(instructions, "Smash ", "挖掘");
            instructions = ReplaceIL(instructions, " rocks", " 岩石");
            instructions = ReplaceIL(instructions, " ore rocks", "矿石");
            instructions = ReplaceIL(instructions, "Smelt some ore into a bar", "熔炼矿石");
            instructions = ReplaceIL(instructions, "Grind ", "磨碎");
            instructions = ReplaceIL(instructions, " stones", "石头");
            instructions = ReplaceIL(instructions, "Cut down ", "砍伐");
            instructions = ReplaceIL(instructions, " trees", "树木");
            instructions = ReplaceIL(instructions, "Clear ", "清理");
            instructions = ReplaceIL(instructions, " tree stumps", "树桩");
            instructions = ReplaceIL(instructions, "Saw ", "锯");
            instructions = ReplaceIL(instructions, " planks", "木板");
            instructions = ReplaceIL(instructions, " Fish", "鱼");
            instructions = ReplaceIL(instructions, " grass", "草");
            instructions = ReplaceIL(instructions, "Pet an animal", "爱抚动物");
            instructions = ReplaceIL(instructions, "Buy some new clothes", "买些新衣服");
            instructions = ReplaceIL(instructions, "Buy some new furniture", "买些新家具");
            instructions = ReplaceIL(instructions, "Buy some new wallpaper", "买些新壁纸");
            instructions = ReplaceIL(instructions, "Buy some new flooring", "买些新地板");
            instructions = ReplaceIL(instructions, "Compost something", "堆肥");
            instructions = ReplaceIL(instructions, "Craft a new tool", "制作新工具");
            instructions = ReplaceIL(instructions, "Buy ", "购买");
            instructions = ReplaceIL(instructions, " seeds", "种子");
            instructions = ReplaceIL(instructions, "Trap an animal and deliver it", "捕获动物并交付");
            instructions = ReplaceIL(instructions, "Hunt ", "狩猎");
            instructions = ReplaceIL(instructions, " animals", "动物");
            instructions = ReplaceIL(instructions, "Buy a new tool", "购买新工具");
            instructions = ReplaceIL(instructions, "Break a tool", "损坏一个工具");
            instructions = ReplaceIL(instructions, "Find some burried treasure", "找到一些埋藏的宝藏");
            instructions = ReplaceIL(instructions, "No mission set", "没有任务");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(TileObjectSettings), "getWhyCantPlaceDeedText")]
        public static IEnumerable<CodeInstruction> TileObjectSettings_getWhyCantPlaceDeedText_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Can't place here", "不能放置在这里");
            instructions = ReplaceIL(instructions, "Someone is in the way", "有人挡住了");
            instructions = ReplaceIL(instructions, "Not on level ground", "不在一个水平面");
            instructions = ReplaceIL(instructions, "Can't be placed in water", "不能放置在水里");
            instructions = ReplaceIL(instructions, "Something in the way", "有物体在这里");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(UseBook), "plantBookRoutine", MethodType.Enumerator)]
        public static IEnumerable<CodeInstruction> UseBook_plantBookRoutine_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, " Plant", "植株");
            instructions = ReplaceIL(instructions, "Ready for harvest", "可收获");
            instructions = ReplaceIL(instructions, "Mature in:\n", "成熟时间:\n");
            instructions = ReplaceIL(instructions, " days.", "天后");
            instructions = ReplaceIL(instructions, " days", "天后");
            instructions = ReplaceIL(instructions, "Plant", "植株");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(WeatherManager), "currentWeather")]
        public static IEnumerable<CodeInstruction> WeatherManager_currentWeather_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "It is currently ", "当前气温");
            instructions = ReplaceIL(instructions, "° and ", "°并且");
            instructions = ReplaceIL(instructions, "Storming", "暴风雨");
            instructions = ReplaceIL(instructions, "Raining", "降雨");
            instructions = ReplaceIL(instructions, "Foggy", "雾气");
            instructions = ReplaceIL(instructions, "Fine", "天气良好");
            instructions = ReplaceIL(instructions, ". With a", "。还有");
            instructions = ReplaceIL(instructions, " Strong", "强烈的");
            instructions = ReplaceIL(instructions, " Light", "微弱的");
            instructions = ReplaceIL(instructions, " Northern ", "北");
            instructions = ReplaceIL(instructions, " Southern ", "南");
            instructions = ReplaceIL(instructions, " Westernly ", "西");
            instructions = ReplaceIL(instructions, " Easternly ", "东");
            instructions = ReplaceIL(instructions, " Wind.", "风。");
            return instructions;
        }

        [HarmonyTranspiler, HarmonyPatch(typeof(WeatherManager), "tomorrowsWeather")]
        public static IEnumerable<CodeInstruction> WeatherManager_tomorrowsWeather_Patch(IEnumerable<CodeInstruction> instructions)
        {
            instructions = ReplaceIL(instructions, "Tomorrow expect ", "明日天气预报:");
            instructions = ReplaceIL(instructions, "Storms", "暴风雨");
            instructions = ReplaceIL(instructions, "Rain", "降雨");
            instructions = ReplaceIL(instructions, "Fog", "雾气");
            instructions = ReplaceIL(instructions, "Fine Weather", "好天气");
            instructions = ReplaceIL(instructions, ". With", "。还有");
            instructions = ReplaceIL(instructions, " Strong", "强烈的");
            instructions = ReplaceIL(instructions, " Light", "微弱的");
            instructions = ReplaceIL(instructions, " Northern ", "北");
            instructions = ReplaceIL(instructions, " Southern ", "南");
            instructions = ReplaceIL(instructions, " Westernly ", "西");
            instructions = ReplaceIL(instructions, " Easternly ", "东");
            instructions = ReplaceIL(instructions, "Wind. With temperatures around ", "风。温度接近");
            instructions = ReplaceIL(instructions, "°.", "°。");
            return instructions;
        }

        // instructions = ReplaceIL(instructions, "", "");
    }
}