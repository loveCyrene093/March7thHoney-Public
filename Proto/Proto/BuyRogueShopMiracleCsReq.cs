using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BuyRogueShopMiracleCsReq : IMessage<BuyRogueShopMiracleCsReq>, IMessage, IEquatable<BuyRogueShopMiracleCsReq>, IDeepCloneable<BuyRogueShopMiracleCsReq>, IBufferMessage
{
	private static readonly MessageParser<BuyRogueShopMiracleCsReq> _parser = new MessageParser<BuyRogueShopMiracleCsReq>(() => new BuyRogueShopMiracleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FGEKLBMLHEKFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_fGEKLBMLHEK_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> fGEKLBMLHEK_ = new RepeatedField<uint>();

	public const int InteractedPropEntityIdFieldNumber = 9;

	private uint interactedPropEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BuyRogueShopMiracleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuyRogueShopMiracleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FGEKLBMLHEK => fGEKLBMLHEK_;

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
	public BuyRogueShopMiracleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopMiracleCsReq(BuyRogueShopMiracleCsReq other)
		: this()
	{
		fGEKLBMLHEK_ = other.fGEKLBMLHEK_.Clone();
		interactedPropEntityId_ = other.interactedPropEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuyRogueShopMiracleCsReq Clone()
	{
		return new BuyRogueShopMiracleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuyRogueShopMiracleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuyRogueShopMiracleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fGEKLBMLHEK_.Equals(other.fGEKLBMLHEK_))
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
		num ^= fGEKLBMLHEK_.GetHashCode();
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
		fGEKLBMLHEK_.WriteTo(ref output, _repeated_fGEKLBMLHEK_codec);
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(72);
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
		num += fGEKLBMLHEK_.CalculateSize(_repeated_fGEKLBMLHEK_codec);
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
	public void MergeFrom(BuyRogueShopMiracleCsReq other)
	{
		if (other != null)
		{
			fGEKLBMLHEK_.Add(other.fGEKLBMLHEK_);
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
			case 32u:
			case 34u:
				fGEKLBMLHEK_.AddEntriesFrom(ref input, _repeated_fGEKLBMLHEK_codec);
				break;
			case 72u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
