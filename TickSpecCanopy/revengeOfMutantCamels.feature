﻿Feature: Searching for "revenge of the mutant camels" on Google should find the Wikipedia page for "Revenge Of The Mutant Camels"

Scenario 1: We should find the Wikipedia page for "Attack Of The Mutant Camels"
    Given I visit http://google.com
    And I type "revenge of the mutant camels" into the input box with the id #gbqfq
    When I press enter
    Then the first result should have the title "Revenge of the Mutant Camels - Wikipedia, the free encyclopedia"