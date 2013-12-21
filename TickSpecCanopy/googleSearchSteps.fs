module featureStepDefinitions

open TickSpec
open canopy

[<Given>]
let ``I visit (.*)`` s = 
    start firefox
    url s

[<Given>]
let ``I type (.*) into the input box with the id (.*)`` s id = id << s

[<When>]
let ``I press enter`` () = press enter

[<Then>]
let ``the first result should have the title "(.*)"`` s = 
    "h3.r a" == s
    quit()