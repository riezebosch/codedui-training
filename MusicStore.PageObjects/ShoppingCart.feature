Feature: ShoppingCart
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add same album twice
	Given I have an empty shopping cart
	When I select 'Rock' from the Store submenu
		And I select 'Led Zeppelin III' from the overview
		And I add this item to the cart
	When I select 'Rock' from the Store submenu
		And I select 'Led Zeppelin III' from the overview
		And I add this item to the cart
	Then the number on the shopping cart should be 2

Scenario: Add different album
	Given I have an empty shopping cart
	When I select 'Jazz' from the Store submenu
		And I select 'Quiet Songs' from the overview
		And I add this item to the cart
	When I select 'Rock' from the Store submenu
		And I select 'Led Zeppelin III' from the overview
		And I add this item to the cart
	Then the number on the shopping cart should be 2

Scenario: Add same album twice short
	Given I have an empty shopping cart
	When I add 'Led Zeppelin III' from the 'Rock' albums
		And I add 'Led Zeppelin III' from the 'Rock' albums
	Then the number on the shopping cart should be 2