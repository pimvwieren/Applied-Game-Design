-> Debug
EXTERNAL isTalking(npcName)
//Fallback function for test inside inky
=== function isTalking(npcName) ===
~return npcName
EXTERNAL startQuest(questId)
//Fallback function for test inside inky
=== function startQuest(questId) ===
~return questId
EXTERNAL completeQuest(questId)
//Fallback function for test inside inky
=== function completeQuest(questId) ===
~return questId

=== Debug ===
Praat met:
    +[Wortel]
    -> Wortel
    +[Biet]
    -> Biet
    
=== Wortel ===

{
    -!eerstekeer:
    -> eerstekeer
   - !tweedekeer:
    -> eerstekeer
    -else:
    -> tweedekeer
}

= eerstekeer
Hallo ik ben de Wortel
En ik weet heeeel veel
    + [Doei Wortel]
    ok doei.
        -> DONE
    * [Hallo Wortel, alles goed?]
    Ja hoor.
    -> DONE
    * [Mag ik nog een keer met je praten?]
    -> Wortel
    * {Biet.leugenaar} [De biet noemt je een leugenaar]
    OH?!
    ->DONE
    
= tweedekeer
Ik heb al met je gepraat
-> DONE
    
= complete
Hey lekker gedaan man!
-> DONE

=== Biet ===

{
    -Wortel.eerstekeer && !eerstekeer:
    -> nawortelgesproken
    -!eerstekeer:
    -> eerstekeer
   - !tweedekeer:
    -> eerstekeer
    -else:
    -> tweedekeer
}

= nawortelgesproken
Je hebt de vuile leugenaar de Wortel al gesproken zo te zien
-> eerstekeer

= eerstekeer
Hallo ik ben de <s><b><color="red">biet</s></color> <b>BIET</b>
    +{nawortelgesproken} [Wat weet jij over de Wortel?]
    Ik weet heeeel veel over hem, hij is een leugenaar.
        ** [Leugenaar?]
        -> leugenaar
        ** [Later Biet]
            Byeee
            -> DONE
    JA!
    -> DONE
    + [Doei Biet]
    Nouja zeg
    -> DONE

= leugenaar
Ja een leugenaar ja, geloof je me niet?
    * [Nee]
    Jammer.
    -> DONE
    * [Ja]
    Goedzo!
    -> DONE
-> DONE

= tweedekeer
Ik heb al met je gepraat sukkel
-> DONE