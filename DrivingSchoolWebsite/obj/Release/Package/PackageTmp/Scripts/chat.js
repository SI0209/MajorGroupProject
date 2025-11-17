// callAsk(message) sends the message to the ASMX and returns a Promise<string>
function callAsk(message) {
    return $.ajax({
        url: '/ChatbotController.asmx/Ask',
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json', // expect JSON
        data: JSON.stringify({ message: message })
    }).then(function (data) {
        // ASMX JSON responses return the value in data.d
        return data && data.d ? data.d : '';
    });
}

// usage example:
$('#sendButton').on('click', function () {
    var msg = $('#messageInput').val();
    $('#chatLog').append('<div class="user">' + msg + '</div>');
    callAsk(msg).then(function (reply) {
        $('#chatLog').append('<div class="bot">' + reply + '</div>');
    }).catch(function (xhr) {
        console.error('AJAX error:', xhr.responseText || xhr.statusText);
        alert('Error reading response. See console for details.');
    });
});