async function callAskFetch(message) {
    const res = await fetch('/ChatbotController.asmx/Ask', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json; charset=utf-8' },
        body: JSON.stringify({ message: message })
    });
    const text = await res.text();
    // ASMX may return JSON text like {"d":"..."} or an HTML error — parse safely
    try {
        const json = JSON.parse(text);
        return json.d || '';
    } catch (e) {
        console.error('Unexpected ASMX response:', text);
        throw new Error('Unexpected response from server');
    }
}