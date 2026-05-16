using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveUpdateLiveRoomTitleCsReq : IMessage<IdleLiveUpdateLiveRoomTitleCsReq>, IMessage, IEquatable<IdleLiveUpdateLiveRoomTitleCsReq>, IDeepCloneable<IdleLiveUpdateLiveRoomTitleCsReq>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		Title = 2,
		FCOKOGNOGCA = 8
	}

	private static readonly MessageParser<IdleLiveUpdateLiveRoomTitleCsReq> _parser = new MessageParser<IdleLiveUpdateLiveRoomTitleCsReq>(() => new IdleLiveUpdateLiveRoomTitleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TitleFieldNumber = 2;

	public const int FCOKOGNOGCAFieldNumber = 8;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveUpdateLiveRoomTitleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveUpdateLiveRoomTitleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		get
		{
			if (!HasTitle)
			{
				return "";
			}
			return (string)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = ProtoPreconditions.CheckNotNull(value, "value");
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.Title;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTitle => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.Title;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCOKOGNOGCA
	{
		get
		{
			if (!HasFCOKOGNOGCA)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.FCOKOGNOGCA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFCOKOGNOGCA => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FCOKOGNOGCA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpdateLiveRoomTitleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpdateLiveRoomTitleCsReq(IdleLiveUpdateLiveRoomTitleCsReq other)
		: this()
	{
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.Title:
			Title = other.Title;
			break;
		case NLPPPCHGGPFOneofCase.FCOKOGNOGCA:
			FCOKOGNOGCA = other.FCOKOGNOGCA;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpdateLiveRoomTitleCsReq Clone()
	{
		return new IdleLiveUpdateLiveRoomTitleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTitle()
	{
		if (HasTitle)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFCOKOGNOGCA()
	{
		if (HasFCOKOGNOGCA)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveUpdateLiveRoomTitleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveUpdateLiveRoomTitleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (FCOKOGNOGCA != other.FCOKOGNOGCA)
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (HasTitle)
		{
			num ^= Title.GetHashCode();
		}
		if (HasFCOKOGNOGCA)
		{
			num ^= FCOKOGNOGCA.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
		if (HasTitle)
		{
			output.WriteRawTag(18);
			output.WriteString(Title);
		}
		if (HasFCOKOGNOGCA)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FCOKOGNOGCA);
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
		if (HasTitle)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (HasFCOKOGNOGCA)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCOKOGNOGCA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveUpdateLiveRoomTitleCsReq other)
	{
		if (other != null)
		{
			switch (other.NLPPPCHGGPFCase)
			{
			case NLPPPCHGGPFOneofCase.Title:
				Title = other.Title;
				break;
			case NLPPPCHGGPFOneofCase.FCOKOGNOGCA:
				FCOKOGNOGCA = other.FCOKOGNOGCA;
				break;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 18u:
				Title = input.ReadString();
				break;
			case 64u:
				FCOKOGNOGCA = input.ReadUInt32();
				break;
			}
		}
	}
}
