﻿Feature: Searching for "mutant camels" on Google should find the Wikipedia page for "Attack Of The Mutant Camels"

Scenario 1: We should find the Wikipedia page for "Attack Of The Mutant Camels"
    Given I visit http://google.com
    And I type "mutant camels" into the input box with the id #gbqfq
    When I press enter
    Then the first result should have the title "Attack of the Mutant Camels - Wikipedia, the free encyclopedia"