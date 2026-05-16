using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AiPamTeamExplainCsReq : IMessage<AiPamTeamExplainCsReq>, IMessage, IEquatable<AiPamTeamExplainCsReq>, IDeepCloneable<AiPamTeamExplainCsReq>, IBufferMessage
{
	private static readonly MessageParser<AiPamTeamExplainCsReq> _parser = new MessageParser<AiPamTeamExplainCsReq>(() => new AiPamTeamExplainCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BHFBIGFEDHLFieldNumber = 4;

	private bool bHFBIGFEDHL_;

	public const int MessageDatasFieldNumber = 5;

	private MessageChatData messageDatas_;

	public const int ELBDJNLMEFNFieldNumber = 9;

	private bool eLBDJNLMEFN_;

	public const int NMLIMJJHOPKFieldNumber = 11;

	private string nMLIMJJHOPK_ = "";

	public const int LLLCJNJHEPEFieldNumber = 13;

	private bool lLLCJNJHEPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AiPamTeamExplainCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AiPamTeamExplainCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BHFBIGFEDHL
	{
		get
		{
			return bHFBIGFEDHL_;
		}
		set
		{
			bHFBIGFEDHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageChatData MessageDatas
	{
		get
		{
			return messageDatas_;
		}
		set
		{
			messageDatas_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ELBDJNLMEFN
	{
		get
		{
			return eLBDJNLMEFN_;
		}
		set
		{
			eLBDJNLMEFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NMLIMJJHOPK
	{
		get
		{
			return nMLIMJJHOPK_;
		}
		set
		{
			nMLIMJJHOPK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LLLCJNJHEPE
	{
		get
		{
			return lLLCJNJHEPE_;
		}
		set
		{
			lLLCJNJHEPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamTeamExplainCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamTeamExplainCsReq(AiPamTeamExplainCsReq other)
		: this()
	{
		bHFBIGFEDHL_ = other.bHFBIGFEDHL_;
		messageDatas_ = ((other.messageDatas_ != null) ? other.messageDatas_.Clone() : null);
		eLBDJNLMEFN_ = other.eLBDJNLMEFN_;
		nMLIMJJHOPK_ = other.nMLIMJJHOPK_;
		lLLCJNJHEPE_ = other.lLLCJNJHEPE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AiPamTeamExplainCsReq Clone()
	{
		return new AiPamTeamExplainCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AiPamTeamExplainCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AiPamTeamExplainCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BHFBIGFEDHL != other.BHFBIGFEDHL)
		{
			return false;
		}
		if (!object.Equals(MessageDatas, other.MessageDatas))
		{
			return false;
		}
		if (ELBDJNLMEFN != other.ELBDJNLMEFN)
		{
			return false;
		}
		if (NMLIMJJHOPK != other.NMLIMJJHOPK)
		{
			return false;
		}
		if (LLLCJNJHEPE != other.LLLCJNJHEPE)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (BHFBIGFEDHL)
		{
			num ^= BHFBIGFEDHL.GetHashCode();
		}
		if (messageDatas_ != null)
		{
			num ^= MessageDatas.GetHashCode();
		}
		if (ELBDJNLMEFN)
		{
			num ^= ELBDJNLMEFN.GetHashCode();
		}
		if (NMLIMJJHOPK.Length != 0)
		{
			num ^= NMLIMJJHOPK.GetHashCode();
		}
		if (LLLCJNJHEPE)
		{
			num ^= LLLCJNJHEPE.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BHFBIGFEDHL)
		{
			output.WriteRawTag(32);
			output.WriteBool(BHFBIGFEDHL);
		}
		if (messageDatas_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MessageDatas);
		}
		if (ELBDJNLMEFN)
		{
			output.WriteRawTag(72);
			output.WriteBool(ELBDJNLMEFN);
		}
		if (NMLIMJJHOPK.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(NMLIMJJHOPK);
		}
		if (LLLCJNJHEPE)
		{
			output.WriteRawTag(104);
			output.WriteBool(LLLCJNJHEPE);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (BHFBIGFEDHL)
		{
			num += 2;
		}
		if (messageDatas_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MessageDatas);
		}
		if (ELBDJNLMEFN)
		{
			num += 2;
		}
		if (NMLIMJJHOPK.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NMLIMJJHOPK);
		}
		if (LLLCJNJHEPE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AiPamTeamExplainCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BHFBIGFEDHL)
		{
			BHFBIGFEDHL = other.BHFBIGFEDHL;
		}
		if (other.messageDatas_ != null)
		{
			if (messageDatas_ == null)
			{
				MessageDatas = new MessageChatData();
			}
			MessageDatas.MergeFrom(other.MessageDatas);
		}
		if (other.ELBDJNLMEFN)
		{
			ELBDJNLMEFN = other.ELBDJNLMEFN;
		}
		if (other.NMLIMJJHOPK.Length != 0)
		{
			NMLIMJJHOPK = other.NMLIMJJHOPK;
		}
		if (other.LLLCJNJHEPE)
		{
			LLLCJNJHEPE = other.LLLCJNJHEPE;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 32u:
				BHFBIGFEDHL = input.ReadBool();
				break;
			case 42u:
				if (messageDatas_ == null)
				{
					MessageDatas = new MessageChatData();
				}
				input.ReadMessage(MessageDatas);
				break;
			case 72u:
				ELBDJNLMEFN = input.ReadBool();
				break;
			case 90u:
				NMLIMJJHOPK = input.ReadString();
				break;
			case 104u:
				LLLCJNJHEPE = input.ReadBool();
				break;
			}
		}
	}
}
