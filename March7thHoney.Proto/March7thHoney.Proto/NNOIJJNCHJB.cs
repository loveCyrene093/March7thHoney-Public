using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NNOIJJNCHJB : IMessage<NNOIJJNCHJB>, IMessage, IEquatable<NNOIJJNCHJB>, IDeepCloneable<NNOIJJNCHJB>, IBufferMessage
{
	private static readonly MessageParser<NNOIJJNCHJB> _parser = new MessageParser<NNOIJJNCHJB>(() => new NNOIJJNCHJB());

	private UnknownFieldSet _unknownFields;

	public const int RelicIdsFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int ReturnItemListFieldNumber = 9;

	private ItemList returnItemList_;

	public const int CIACHEIMDDMFieldNumber = 14;

	private bool cIACHEIMDDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NNOIJJNCHJB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NNOIJJNCHJBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RelicIds => relicIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ReturnItemList
	{
		get
		{
			return returnItemList_;
		}
		set
		{
			returnItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CIACHEIMDDM
	{
		get
		{
			return cIACHEIMDDM_;
		}
		set
		{
			cIACHEIMDDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNOIJJNCHJB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNOIJJNCHJB(NNOIJJNCHJB other)
		: this()
	{
		relicIds_ = other.relicIds_.Clone();
		returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
		cIACHEIMDDM_ = other.cIACHEIMDDM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNOIJJNCHJB Clone()
	{
		return new NNOIJJNCHJB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NNOIJJNCHJB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NNOIJJNCHJB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (!object.Equals(ReturnItemList, other.ReturnItemList))
		{
			return false;
		}
		if (CIACHEIMDDM != other.CIACHEIMDDM)
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
		num ^= relicIds_.GetHashCode();
		if (returnItemList_ != null)
		{
			num ^= ReturnItemList.GetHashCode();
		}
		if (CIACHEIMDDM)
		{
			num ^= CIACHEIMDDM.GetHashCode();
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
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (returnItemList_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ReturnItemList);
		}
		if (CIACHEIMDDM)
		{
			output.WriteRawTag(112);
			output.WriteBool(CIACHEIMDDM);
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
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (returnItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnItemList);
		}
		if (CIACHEIMDDM)
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
	public void MergeFrom(NNOIJJNCHJB other)
	{
		if (other == null)
		{
			return;
		}
		relicIds_.Add(other.relicIds_);
		if (other.returnItemList_ != null)
		{
			if (returnItemList_ == null)
			{
				ReturnItemList = new ItemList();
			}
			ReturnItemList.MergeFrom(other.ReturnItemList);
		}
		if (other.CIACHEIMDDM)
		{
			CIACHEIMDDM = other.CIACHEIMDDM;
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
			case 8u:
			case 10u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 74u:
				if (returnItemList_ == null)
				{
					ReturnItemList = new ItemList();
				}
				input.ReadMessage(ReturnItemList);
				break;
			case 112u:
				CIACHEIMDDM = input.ReadBool();
				break;
			}
		}
	}
}
