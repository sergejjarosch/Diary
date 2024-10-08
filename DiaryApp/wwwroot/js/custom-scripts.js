function confirmDelete(event) {
    // Verhindert das sofortige Ausführen des Links
    event.preventDefault();

    // Modal anhand der ID auswählen und anzeigen
    var deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
    deleteModal.show();

    // Hier speichern wir den Link (oder die Aktion), die gelöscht werden soll
    document.getElementById('confirmDeleteButton').setAttribute('data-delete-url', event.target.getAttribute('href'));
}

function performDelete() {
    // Die gespeicherte Lösch-URL holen
    var deleteUrl = document.getElementById('confirmDeleteButton').getAttribute('data-delete-url');

    // Weiterleitung zu der Lösch-URL (z.B. der Delete-Action im Controller)
    window.location.href = deleteUrl;
}
