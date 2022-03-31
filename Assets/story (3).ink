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
EXTERNAL zegiets(inputQueryId)
=== function zegiets(inputQueryId) ===
~return zegiets
EXTERNAL TakeIngredient(ingredientId)
=== function TakeIngredient(ingredientId) ===
~return zegiets
=== Debug ===
-> DONE

=== Prei ===
{   -!intro:
    -> intro
    -else:
    -> fallback
}

= intro

“Welcome to the Warlock TV Tower, my friends! I am the most trusted of the Warlock himself. Clippy, you can trust.”
*[Continue]
“You're here to create the spell no?”
**[Continue]
“Then the first step is to create the potion, more can be found in The Book.”
***[Continue]
“For that you need those stinky sentient ingredients – all of your options can be found on the table!”
****[Continue]
“Yes.. definitely <b>all</b> your options are there.. hehe..” 
-> DONE

= fallback
“Take your time! Relax. It's not like the world is ending.”
*[Are you an ingredient?]
“Whaat? Mee? You're so funny!"
**[Continue]
"Anyway. Listen to this! I once saw the Crystal and Herb arguing with each other – it was crazy.”
***[Continue]
Clippy proceeds to rant on about irrelevant things...
-> DONE
+ [Say something...]
~ zegiets(1)
-> DONE

=== Banana ===

{
    -!eerstekeer:
    -> eerstekeer
    -else:
    -> eerstekeer
}

= eerstekeer
“That Crystal is such a cockroach. I heard he likes to sucks up to everyone and supports the destruction of our beautiful city. ”
*[Continue]
-> DONE
+ [Say something...]
~ zegiets(0)
-> DONE

=== Herbs ===

{
    -!eerstekeer:
    -> eerstekeer
    -else:
    -> eerstekeer
}

= eerstekeer
“Hello mister, isn't living just neat? I love to be alive.”
*[Continue]
-> DONE
+ [Say something...]
~ zegiets(0)
-> DONE

=== Crystal ===

{
    -!eerstekeer:
    -> eerstekeer
    -else:
    -> eerstekeer
}

= eerstekeer
“Wow – your skin is radiant. You're beautiful, you're fierce, you're the moment.”
*[Continue]
-> DONE
+ [Say something...]
~ zegiets(0)
-> DONE

=== Courgette ===

{
    -!eerstekeer:
    -> eerstekeer
    -else:
    -> eerstekeer
}

= eerstekeer
 “Based on scientific evidence, it is more organic and sustainable to use Herbs in your potion than something like me. It's not only more natural but a large demographic approves of this choice.” 
*[Continue]
-> DONE
+ [Say something...]
~ zegiets(2)
-> DONE
= tweedekeer
Ik heb al met je gepraat sukkel
-> DONE