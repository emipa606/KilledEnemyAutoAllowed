# GitHub Copilot Instructions for RimWorld Modding Project: KilledEnemyAutoAllowed (Continued)

## Mod Overview and Purpose

**Mod Name:** KilledEnemyAutoAllowed (Continued)

**Description:** This mod is a continuation and update of Darkside's original mod, with a focus on automatic management of dropped items. When an enemy is killed, any items they drop are automatically marked as "allowed," regardless of their location relative to the Home Area. This ensures all pawns, including colonists, can interact with these items immediately without manual intervention.

## Key Features and Systems

- **Automatic Allowance of Dropped Items:** Automatically sets items dropped by killed enemies to be allowed for interaction, simplifying resource management.
- **Compatibility with Other Mods:** The mod code has been refactored to utilize Harmony patches, allowing for better interoperability with other mods.

## Coding Patterns and Conventions

- **Harmony Patching:** The mod relies on Harmony to patch the game's methods to implement its features. This involves using prefix patches to modify behavior before the original method runs.
- **C# Best Practices:** Use of clear and descriptive class and method names to improve code readability. Ensure methods encapsulate distinct pieces of functionality.
- **Consistent Naming Conventions:** Follow CamelCase for method and class names. Use PascalCase for public properties and fields.

## XML Integration

Currently, the mod does not integrate XML files or defs. The focus is on C# code and Harmony patches to achieve the desired functionality in-game. If future updates require XML, consider following RimWorld's XML structure and naming convention guidelines.

## Harmony Patching

- **Harmony Dependency:** The mod relies on `brrainz.harmony` for patching game functionality.
- **Implemented Patches:**
  - **ForbidUtility_SetForbiddenIfOutsideHomeArea:** Custom logic to manage item permissions as they are dropped.
  - **Pawn_EquipmentTracker_DropAllEquipment:** Ensures that equipment dropped is immediately allowed.
  - **Pawn_InventoryTracker_DropAllNearPawn:** Handles inventory items, ensuring they're usable immediately.

## Suggestions for Copilot

1. **Code Completion for C# Classes:** Utilize Copilot to suggest and complete C# class structures, helping streamline the creation of new classes for additional features.
2. **Method Stubs Creation:** Implement stub methods for new functionality, leveraging Copilot’s suggestions based on existing patterns.
3. **Harmony Patch Patterns:** Suggest patch structures for new game methods and provide templates for prefix/postfix patches.
4. **Error Handling:** Use Copilot to suggest robust error handling patterns to prevent the mod from causing unintended crashes.
5. **Documentation Generation:** Generate in-line comments and XML documentation for methods using Copilot to ensure code maintainability and clarity.

By following the guidelines outlined in this document, developers can effectively contribute to and expand the KilledEnemyAutoAllowed (Continued) mod, ensuring consistent functionality and easy-to-understand codebase. This document should also help Copilot provide relevant and context-aware suggestions that align with the project's goals and coding standards.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

