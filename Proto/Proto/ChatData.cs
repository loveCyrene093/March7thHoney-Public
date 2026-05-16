using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatData : IMessage<ChatData>, IMessage, IEquatable<ChatData>, IDeepCloneable<ChatData>, IBufferMessage
{
	public enum ExtendTypeOneofCase
	{
		None = 0,
		EPKIJKOHNKC = 101,
		MOELBPPIPDC = 102,
		MessageText = 103,
		ExtraId = 104,
		IMOLBGOCNEI = 105,
		BAEABLOBEGI = 106,
		DLBNMNCPEEH = 107,
		MPGEJDAEOGJ = 108,
		CMFDCKANPGD = 109,
		LEGOJPMNCLL = 110
	}

	private static readonly MessageParser<ChatData> _parser = new MessageParser<ChatData>(() => new ChatData());

	private UnknownFieldSet _unknownFields;

	public const int EPKIJKOHNKCFieldNumber = 101;

	public const int MOELBPPIPDCFieldNumber = 102;

	public const int MessageTextFieldNumber = 103;

	public const int ExtraIdFieldNumber = 104;

	public const int IMOLBGOCNEIFieldNumber = 105;

	public const int BAEABLOBEGIFieldNumber = 106;

	public const int DLBNMNCPEEHFieldNumber = 107;

	public const int MPGEJDAEOGJFieldNumber = 108;

	public const int CMFDCKANPGDFieldNumber = 109;

	public const int LEGOJPMNCLLFieldNumber = 110;

	private object extendType_;

	private ExtendTypeOneofCase extendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChatData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChatDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKDDLMJLEN EPKIJKOHNKC
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.EPKIJKOHNKC)
			{
				return null;
			}
			return (CIKDDLMJLEN)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.EPKIJKOHNKC : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMLBJFHEAKL MOELBPPIPDC
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.MOELBPPIPDC)
			{
				return null;
			}
			return (MMLBJFHEAKL)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.MOELBPPIPDC : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MessageText
	{
		get
		{
			if (!HasMessageText)
			{
				return "";
			}
			return (string)extendType_;
		}
		set
		{
			extendType_ = ProtoPreconditions.CheckNotNull(value, "value");
			extendTypeCase_ = ExtendTypeOneofCase.MessageText;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMessageText => extendTypeCase_ == ExtendTypeOneofCase.MessageText;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraId
	{
		get
		{
			if (!HasExtraId)
			{
				return 0u;
			}
			return (uint)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ExtendTypeOneofCase.ExtraId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasExtraId => extendTypeCase_ == ExtendTypeOneofCase.ExtraId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEKNOBDHAKO IMOLBGOCNEI
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.IMOLBGOCNEI)
			{
				return null;
			}
			return (PEKNOBDHAKO)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.IMOLBGOCNEI : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEBBEGGFJMI BAEABLOBEGI
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.BAEABLOBEGI)
			{
				return null;
			}
			return (MEBBEGGFJMI)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.BAEABLOBEGI : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OIJJJKLMFNO DLBNMNCPEEH
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.DLBNMNCPEEH)
			{
				return null;
			}
			return (OIJJJKLMFNO)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.DLBNMNCPEEH : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECLEPFKJFLC MPGEJDAEOGJ
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.MPGEJDAEOGJ)
			{
				return null;
			}
			return (ECLEPFKJFLC)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.MPGEJDAEOGJ : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDLBDDHKDJ CMFDCKANPGD
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.CMFDCKANPGD)
			{
				return null;
			}
			return (CHDLBDDHKDJ)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.CMFDCKANPGD : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNOCGFDGHEB LEGOJPMNCLL
	{
		get
		{
			if (extendTypeCase_ != ExtendTypeOneofCase.LEGOJPMNCLL)
			{
				return null;
			}
			return (JNOCGFDGHEB)extendType_;
		}
		set
		{
			extendType_ = value;
			extendTypeCase_ = ((value != null) ? ExtendTypeOneofCase.LEGOJPMNCLL : ExtendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtendTypeOneofCase ExtendTypeCase => extendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatData(ChatData other)
		: this()
	{
		switch (other.ExtendTypeCase)
		{
		case ExtendTypeOneofCase.EPKIJKOHNKC:
			EPKIJKOHNKC = other.EPKIJKOHNKC.Clone();
			break;
		case ExtendTypeOneofCase.MOELBPPIPDC:
			MOELBPPIPDC = other.MOELBPPIPDC.Clone();
			break;
		case ExtendTypeOneofCase.MessageText:
			MessageText = other.MessageText;
			break;
		case ExtendTypeOneofCase.ExtraId:
			ExtraId = other.ExtraId;
			break;
		case ExtendTypeOneofCase.IMOLBGOCNEI:
			IMOLBGOCNEI = other.IMOLBGOCNEI.Clone();
			break;
		case ExtendTypeOneofCase.BAEABLOBEGI:
			BAEABLOBEGI = other.BAEABLOBEGI.Clone();
			break;
		case ExtendTypeOneofCase.DLBNMNCPEEH:
			DLBNMNCPEEH = other.DLBNMNCPEEH.Clone();
			break;
		case ExtendTypeOneofCase.MPGEJDAEOGJ:
			MPGEJDAEOGJ = other.MPGEJDAEOGJ.Clone();
			break;
		case ExtendTypeOneofCase.CMFDCKANPGD:
			CMFDCKANPGD = other.CMFDCKANPGD.Clone();
			break;
		case ExtendTypeOneofCase.LEGOJPMNCLL:
			LEGOJPMNCLL = other.LEGOJPMNCLL.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatData Clone()
	{
		return new ChatData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMessageText()
	{
		if (HasMessageText)
		{
			ClearExtendType();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearExtraId()
	{
		if (HasExtraId)
		{
			ClearExtendType();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearExtendType()
	{
		extendTypeCase_ = ExtendTypeOneofCase.None;
		extendType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChatData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EPKIJKOHNKC, other.EPKIJKOHNKC))
		{
			return false;
		}
		if (!object.Equals(MOELBPPIPDC, other.MOELBPPIPDC))
		{
			return false;
		}
		if (MessageText != other.MessageText)
		{
			return false;
		}
		if (ExtraId != other.ExtraId)
		{
			return false;
		}
		if (!object.Equals(IMOLBGOCNEI, other.IMOLBGOCNEI))
		{
			return false;
		}
		if (!object.Equals(BAEABLOBEGI, other.BAEABLOBEGI))
		{
			return false;
		}
		if (!object.Equals(DLBNMNCPEEH, other.DLBNMNCPEEH))
		{
			return false;
		}
		if (!object.Equals(MPGEJDAEOGJ, other.MPGEJDAEOGJ))
		{
			return false;
		}
		if (!object.Equals(CMFDCKANPGD, other.CMFDCKANPGD))
		{
			return false;
		}
		if (!object.Equals(LEGOJPMNCLL, other.LEGOJPMNCLL))
		{
			return false;
		}
		if (ExtendTypeCase != other.ExtendTypeCase)
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
		if (extendTypeCase_ == ExtendTypeOneofCase.EPKIJKOHNKC)
		{
			num ^= EPKIJKOHNKC.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MOELBPPIPDC)
		{
			num ^= MOELBPPIPDC.GetHashCode();
		}
		if (HasMessageText)
		{
			num ^= MessageText.GetHashCode();
		}
		if (HasExtraId)
		{
			num ^= ExtraId.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.IMOLBGOCNEI)
		{
			num ^= IMOLBGOCNEI.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.BAEABLOBEGI)
		{
			num ^= BAEABLOBEGI.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.DLBNMNCPEEH)
		{
			num ^= DLBNMNCPEEH.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MPGEJDAEOGJ)
		{
			num ^= MPGEJDAEOGJ.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.CMFDCKANPGD)
		{
			num ^= CMFDCKANPGD.GetHashCode();
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.LEGOJPMNCLL)
		{
			num ^= LEGOJPMNCLL.GetHashCode();
		}
		num ^= (int)extendTypeCase_;
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
		if (extendTypeCase_ == ExtendTypeOneofCase.EPKIJKOHNKC)
		{
			output.WriteRawTag(170, 6);
			output.WriteMessage(EPKIJKOHNKC);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MOELBPPIPDC)
		{
			output.WriteRawTag(178, 6);
			output.WriteMessage(MOELBPPIPDC);
		}
		if (HasMessageText)
		{
			output.WriteRawTag(186, 6);
			output.WriteString(MessageText);
		}
		if (HasExtraId)
		{
			output.WriteRawTag(192, 6);
			output.WriteUInt32(ExtraId);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.IMOLBGOCNEI)
		{
			output.WriteRawTag(202, 6);
			output.WriteMessage(IMOLBGOCNEI);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.BAEABLOBEGI)
		{
			output.WriteRawTag(210, 6);
			output.WriteMessage(BAEABLOBEGI);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.DLBNMNCPEEH)
		{
			output.WriteRawTag(218, 6);
			output.WriteMessage(DLBNMNCPEEH);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MPGEJDAEOGJ)
		{
			output.WriteRawTag(226, 6);
			output.WriteMessage(MPGEJDAEOGJ);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.CMFDCKANPGD)
		{
			output.WriteRawTag(234, 6);
			output.WriteMessage(CMFDCKANPGD);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.LEGOJPMNCLL)
		{
			output.WriteRawTag(242, 6);
			output.WriteMessage(LEGOJPMNCLL);
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
		if (extendTypeCase_ == ExtendTypeOneofCase.EPKIJKOHNKC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EPKIJKOHNKC);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MOELBPPIPDC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MOELBPPIPDC);
		}
		if (HasMessageText)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MessageText);
		}
		if (HasExtraId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(ExtraId);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.IMOLBGOCNEI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IMOLBGOCNEI);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.BAEABLOBEGI)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BAEABLOBEGI);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.DLBNMNCPEEH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DLBNMNCPEEH);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.MPGEJDAEOGJ)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MPGEJDAEOGJ);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.CMFDCKANPGD)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CMFDCKANPGD);
		}
		if (extendTypeCase_ == ExtendTypeOneofCase.LEGOJPMNCLL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LEGOJPMNCLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChatData other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.ExtendTypeCase)
		{
		case ExtendTypeOneofCase.EPKIJKOHNKC:
			if (EPKIJKOHNKC == null)
			{
				EPKIJKOHNKC = new CIKDDLMJLEN();
			}
			EPKIJKOHNKC.MergeFrom(other.EPKIJKOHNKC);
			break;
		case ExtendTypeOneofCase.MOELBPPIPDC:
			if (MOELBPPIPDC == null)
			{
				MOELBPPIPDC = new MMLBJFHEAKL();
			}
			MOELBPPIPDC.MergeFrom(other.MOELBPPIPDC);
			break;
		case ExtendTypeOneofCase.MessageText:
			MessageText = other.MessageText;
			break;
		case ExtendTypeOneofCase.ExtraId:
			ExtraId = other.ExtraId;
			break;
		case ExtendTypeOneofCase.IMOLBGOCNEI:
			if (IMOLBGOCNEI == null)
			{
				IMOLBGOCNEI = new PEKNOBDHAKO();
			}
			IMOLBGOCNEI.MergeFrom(other.IMOLBGOCNEI);
			break;
		case ExtendTypeOneofCase.BAEABLOBEGI:
			if (BAEABLOBEGI == null)
			{
				BAEABLOBEGI = new MEBBEGGFJMI();
			}
			BAEABLOBEGI.MergeFrom(other.BAEABLOBEGI);
			break;
		case ExtendTypeOneofCase.DLBNMNCPEEH:
			if (DLBNMNCPEEH == null)
			{
				DLBNMNCPEEH = new OIJJJKLMFNO();
			}
			DLBNMNCPEEH.MergeFrom(other.DLBNMNCPEEH);
			break;
		case ExtendTypeOneofCase.MPGEJDAEOGJ:
			if (MPGEJDAEOGJ == null)
			{
				MPGEJDAEOGJ = new ECLEPFKJFLC();
			}
			MPGEJDAEOGJ.MergeFrom(other.MPGEJDAEOGJ);
			break;
		case ExtendTypeOneofCase.CMFDCKANPGD:
			if (CMFDCKANPGD == null)
			{
				CMFDCKANPGD = new CHDLBDDHKDJ();
			}
			CMFDCKANPGD.MergeFrom(other.CMFDCKANPGD);
			break;
		case ExtendTypeOneofCase.LEGOJPMNCLL:
			if (LEGOJPMNCLL == null)
			{
				LEGOJPMNCLL = new JNOCGFDGHEB();
			}
			LEGOJPMNCLL.MergeFrom(other.LEGOJPMNCLL);
			break;
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
			case 810u:
			{
				CIKDDLMJLEN cIKDDLMJLEN = new CIKDDLMJLEN();
				if (extendTypeCase_ == ExtendTypeOneofCase.EPKIJKOHNKC)
				{
					cIKDDLMJLEN.MergeFrom(EPKIJKOHNKC);
				}
				input.ReadMessage(cIKDDLMJLEN);
				EPKIJKOHNKC = cIKDDLMJLEN;
				break;
			}
			case 818u:
			{
				MMLBJFHEAKL mMLBJFHEAKL = new MMLBJFHEAKL();
				if (extendTypeCase_ == ExtendTypeOneofCase.MOELBPPIPDC)
				{
					mMLBJFHEAKL.MergeFrom(MOELBPPIPDC);
				}
				input.ReadMessage(mMLBJFHEAKL);
				MOELBPPIPDC = mMLBJFHEAKL;
				break;
			}
			case 826u:
				MessageText = input.ReadString();
				break;
			case 832u:
				ExtraId = input.ReadUInt32();
				break;
			case 842u:
			{
				PEKNOBDHAKO pEKNOBDHAKO = new PEKNOBDHAKO();
				if (extendTypeCase_ == ExtendTypeOneofCase.IMOLBGOCNEI)
				{
					pEKNOBDHAKO.MergeFrom(IMOLBGOCNEI);
				}
				input.ReadMessage(pEKNOBDHAKO);
				IMOLBGOCNEI = pEKNOBDHAKO;
				break;
			}
			case 850u:
			{
				MEBBEGGFJMI mEBBEGGFJMI = new MEBBEGGFJMI();
				if (extendTypeCase_ == ExtendTypeOneofCase.BAEABLOBEGI)
				{
					mEBBEGGFJMI.MergeFrom(BAEABLOBEGI);
				}
				input.ReadMessage(mEBBEGGFJMI);
				BAEABLOBEGI = mEBBEGGFJMI;
				break;
			}
			case 858u:
			{
				OIJJJKLMFNO oIJJJKLMFNO = new OIJJJKLMFNO();
				if (extendTypeCase_ == ExtendTypeOneofCase.DLBNMNCPEEH)
				{
					oIJJJKLMFNO.MergeFrom(DLBNMNCPEEH);
				}
				input.ReadMessage(oIJJJKLMFNO);
				DLBNMNCPEEH = oIJJJKLMFNO;
				break;
			}
			case 866u:
			{
				ECLEPFKJFLC eCLEPFKJFLC = new ECLEPFKJFLC();
				if (extendTypeCase_ == ExtendTypeOneofCase.MPGEJDAEOGJ)
				{
					eCLEPFKJFLC.MergeFrom(MPGEJDAEOGJ);
				}
				input.ReadMessage(eCLEPFKJFLC);
				MPGEJDAEOGJ = eCLEPFKJFLC;
				break;
			}
			case 874u:
			{
				CHDLBDDHKDJ cHDLBDDHKDJ = new CHDLBDDHKDJ();
				if (extendTypeCase_ == ExtendTypeOneofCase.CMFDCKANPGD)
				{
					cHDLBDDHKDJ.MergeFrom(CMFDCKANPGD);
				}
				input.ReadMessage(cHDLBDDHKDJ);
				CMFDCKANPGD = cHDLBDDHKDJ;
				break;
			}
			case 882u:
			{
				JNOCGFDGHEB jNOCGFDGHEB = new JNOCGFDGHEB();
				if (extendTypeCase_ == ExtendTypeOneofCase.LEGOJPMNCLL)
				{
					jNOCGFDGHEB.MergeFrom(LEGOJPMNCLL);
				}
				input.ReadMessage(jNOCGFDGHEB);
				LEGOJPMNCLL = jNOCGFDGHEB;
				break;
			}
			}
		}
	}
}
