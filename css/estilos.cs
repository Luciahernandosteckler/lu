/* Error: expected ";".
 *   ,
 * 3 |   display: flex,
 *   |          ^
 *   '
 *   scss\estilos.scss 3:10  root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: 'Error: expected ";".\a   \2577 \a 3 \2502    display: flex,\d\a   \2502           ^\a   \2575 \a   scss\\estilos.scss 3:10  root stylesheet';
}
