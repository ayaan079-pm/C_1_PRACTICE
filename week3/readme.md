# WEEK 3 — CHAPTER 3: MAKING DECISIONS
## C# Windows Forms — Code and English Explanations

### How to use these examples
1. Open your Windows Forms project in Visual Studio.
2. Add the controls mentioned in each example (for example, a TextBox named `textBoxAge`).
3. Double-click the relevant Button in the Designer to create its Click event handler.
4. Paste the example statements inside that event handler. For the Form Load example, use the form's Load event.
5. If your control names are different, replace the example names with your own names.
6. Add `using System;` and other required namespaces at the top of the form file if they are not already present.

**Important:** These are focused code examples, not complete projects. Do not paste an event-handler snippet outside a method. The ListBox example contains several separate operations; use the operation you need in the appropriate event handler.

---

## 01. If Statement
**Purpose:** Executes a block only when a condition is true.

**Explanation:** The variable `age` stores 20. The condition `age >= 18` checks whether the age is at least 18. If it is true, `MessageBox.Show` displays the message. If the condition is false, the block is skipped.

**Key point:** `if` is used to make a decision based on a condition.

## 02. If-Else Statement
**Purpose:** Chooses between two possible actions.

**Explanation:** The program checks whether `score` is 50 or higher. If true, it displays Pass. Otherwise, the `else` block displays Fail. Only one of the two blocks runs.

**Key point:** Use `else` when you need an alternative action.

## 03. Nested If
**Purpose:** Places one decision inside another decision.

**Explanation:** The program first checks the person's age. It checks `hasID` only if the age is 18 or above. A person under 18 receives the final message in the outer `else` block.

**Key point:** The inner `if` is reached only when the outer condition is true.

## 04. If-Else-If Ladder
**Purpose:** Checks several conditions and selects the first matching one.

**Explanation:** The program checks the mark from the highest grade range to the lowest. When a condition is true, its message is displayed and the remaining branches are skipped. The final `else` handles marks below 50.

**Key point:** Put conditions in the correct order, especially when ranges overlap.

## 05. Logical Operators
**Purpose:** Combines or reverses conditions.

**Explanation:**
- `&&` means AND. Both conditions must be true.
- `||` means OR. At least one condition must be true.
- `!` means NOT. It reverses a Boolean condition.

The examples show how these operators can be used inside `if` statements.

**Key point:** Logical operators help test more than one condition.

## 06. Boolean Variable / Flag
**Purpose:** Stores a true-or-false value to represent a state.

**Explanation:** `isRegistered` starts as `false`, meaning registration is not complete. After registration, the program changes it to `true`. A flag helps the program remember whether something has happened.

**Key point:** A `bool` variable can contain only `true` or `false`.

## 07. Comparing Strings
**Purpose:** Checks whether text values are equal or different.

**Explanation:** The `==` operator checks whether `name1` and `name2` contain the same text. `String.Compare` returns 0 when the strings are equal. The `!=` operator checks that a value is not equal to another value.

**Key point:** Strings store text, and comparison can be used in decision structures.

## 08. TryParse
**Purpose:** Converts text into a number without throwing a conversion exception for invalid input.

**Explanation:** TextBox content is text, so `int.TryParse` attempts to convert it into an integer. The result is stored in `age`. The method returns `true` when conversion succeeds and `false` when it fails. The `out` keyword allows the converted value to be placed in the variable.

**Key point:** Use `TryParse` when users enter numeric data.

## 09. Input Validation
**Purpose:** Checks that input is both numeric and within an acceptable range.

**Explanation:** First, `int.TryParse` checks whether the TextBox contains a whole number. If it succeeds, the program checks whether the score is between 0 and 100. A value such as 999 is numeric, but it is not an acceptable test score.

**Key point:** Successful conversion does not automatically mean the value is reasonable.

## 10. RadioButtons and CheckBoxes
**Purpose:** Reads the user's selections from a form.

**Explanation:** RadioButtons are commonly used when the user must select one option from a group. Selecting one normally deselects the other option in that group. CheckBoxes allow multiple independent selections. The `.Checked` property tells whether a control is selected.

**Key point:** Use `Checked` to test a RadioButton or CheckBox selection.

## 11. Switch Statement
**Purpose:** Selects an action from several possible constant values.

**Explanation:** The `switch` statement checks the value of `day`. The matching `case` displays the correct day. `break` exits the switch after that case. `default` runs when none of the cases match.

**Key point:** `switch` is useful when one variable is compared with several specific values.

## 12. ListBox Operations
**Purpose:** Adds, reads, removes, and clears items in a ListBox.

**Explanation:**
- `Items.Add(...)` adds a new item.
- `SelectedItem` gets the selected item.
- `SelectedIndex != -1` checks that an item is selected.
- `Items.Remove(...)` removes a particular item.
- `Items.RemoveAt(0)` removes the first item (index 0).
- `Items.Clear()` removes every item.

**Key point:** Check that an item is selected or that the list is not empty before removing items.
