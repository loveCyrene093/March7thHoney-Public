using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueShopFormulaInfoCsReq : IMessage<GetRogueShopFormulaInfoCsReq>, IMessage, IEquatable<GetRogueShopFormulaInfoCsReq>, IDeepCloneable<GetRogueShopFormulaInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetRogueShopFormulaInfoCsReq> _parser = new MessageParser<GetRogueShopFormulaInfoCsReq>(() => new GetRogueShopFormulaInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NOKNNMPMGGNFieldNumber = 6;

	private bool nOKNNMPMGGN_;

	public const int InteractedPropEntityIdFieldNumber = 13;

	private uint interactedPropEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueShopFormulaInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueShopFormulaInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NOKNNMPMGGN
	{
		get
		{
			return nOKNNMPMGGN_;
		}
		set
		{
			nOKNNMPMGGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopFormulaInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopFormulaInfoCsReq(GetRogueShopFormulaInfoCsReq other)
		: this()
	{
		nOKNNMPMGGN_ = other.nOKNNMPMGGN_;
		interactedPropEntityId_ = other.interactedPropEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueShopFormulaInfoCsReq Clone()
	{
		return new GetRogueShopFormulaInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueShopFormulaInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueShopFormulaInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NOKNNMPMGGN != other.NOKNNMPMGGN)
		{
			return false;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
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
		if (NOKNNMPMGGN)
		{
			num ^= NOKNNMPMGGN.GetHashCode();
		}
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
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
		if (NOKNNMPMGGN)
		{
			output.WriteRawTag(48);
			output.WriteBool(NOKNNMPMGGN);
		}
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(InteractedPropEntityId);
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
		if (NOKNNMPMGGN)
		{
			num += 2;
		}
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRogueShopFormulaInfoCsReq other)
	{
		if (other != null)
		{
			if (other.NOKNNMPMGGN)
			{
				NOKNNMPMGGN = other.NOKNNMPMGGN;
			}
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
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
			case 48u:
				NOKNNMPMGGN = input.ReadBool();
				break;
			case 104u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
