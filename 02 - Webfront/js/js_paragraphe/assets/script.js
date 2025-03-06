    const paragraphe = document.getElementById('monParagraphe');
    const boutonAugmenter = document.getElementById('augmenter');
    const boutonDiminuer = document.getElementById('diminuer');
    const tailleTexteAffichee = document.getElementById('tailleTexteAffichee');
    let tailleTexte = 16; // Taille de texte par défaut

    paragraphe.style.fontSize = tailleTexte + 'px';
    tailleTexteAffichee.textContent = tailleTexte + 'px';

    boutonAugmenter.addEventListener('click', function() {
        tailleTexte++;
        if (tailleTexte > 48) {
            tailleTexte = 16;
        }
        paragraphe.style.fontSize = tailleTexte + 'px';
        tailleTexteAffichee.textContent = tailleTexte + 'px';
    });

    boutonDiminuer.addEventListener('click', function() {
        tailleTexte--;
        if (tailleTexte < 8) {
            tailleTexte = 16;
        }
        paragraphe.style.fontSize = tailleTexte + 'px';
        tailleTexteAffichee.textContent = tailleTexte + 'px';
    });