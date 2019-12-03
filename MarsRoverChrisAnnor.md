# Chris Annor - Strategic Insight

I decided to have a go at athe technical assignment for the Interview last week  to show how I would tackle the problem if I had more time.

## Getting Started

The application runs as a console app and will prompt the user for a valid input string

```
Welcome to the Mars Rover console app...
Please enter a valid rover command using a combination of 'L','R' and digits 1-9
L
Final position 0 0 West
Mission complete!
```


## Running the tests

Test are included in the `MarsRoverTests` project

I made the following assumptions:
 * Each character is a unique command
   * The implication of this is you can only move up to 9 spaces per single command so a`11` moves you forward twice rather than 11 spaces which could be achieved buy any sums before cahnging direction adding up to the desired steps.

The following unit tests are passing:

- [x] Turn_in_the_right_direction_when_direction_command_given
- [x] Move_in_the_right_direction_when_command_is_given
- [x] Remain_on_grid_given_valid_commands_for_appropriate_grid
- [x] Return_throw_invalid_exception_when_invalid_input_is_entered
