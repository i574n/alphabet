# alphabet

<https://i574n.github.io/alphabet>

[![깃허브 코드스페이스](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=919742788)

Writing-system tools in Spiral: render markdown documents as books, each with a Korean (hangul) transcription alongside it.

## Apps

| App | What it does |
| --- | --- |
| `apps/documents` | Walks a source tree of `.md` files and renders each to HTML, PDF and EPUB with [crowbook](https://github.com/crowdagger/crowbook). It also writes a hangul transcription (`.hangul.md`) through [hangulize](https://github.com/i574n/hangulize), with the spec chosen per document (`--hangul-spec`, default `por-br`; English text uses `eng`), and renders that too. Unchanged files are skipped by content hash against a cache dir. `--transcribe-only` keeps only the transcribed lines, and `--filter` limits the run to matching paths. [vault](https://github.com/i574n/vault) publishes with it. |
| `apps/hangul` | Hangul in Spiral: syllable composition and decomposition, jamo and compatibility letters, hanja-to-hangul readings over a full hanja table, particle selection, stroke counts, and CP949 decoding and encoding with typed failures. |

## Getting started

```powershell
git clone https://github.com/i574n/alphabet.git
cd alphabet
pwsh scripts/workflow.ps1
```

`scripts/init.ps1` clones [spiral](https://github.com/i574n/spiral) next to this repository and runs its toolchain setup, then installs pandoc, crowbook, tectonic, the NanumGothicCoding font and hangulize.

## Links

- Repository file tree: <https://i574n.github.io/alphabet>

## Contributing

See [CONTRIBUTING.md](https://github.com/i574n/.github/blob/main/CONTRIBUTING.md).

## License

AGPL v3; see [LICENSE](LICENSE).
