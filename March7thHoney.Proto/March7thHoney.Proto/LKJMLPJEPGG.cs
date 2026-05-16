using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKJMLPJEPGG : IMessage<LKJMLPJEPGG>, IMessage, IEquatable<LKJMLPJEPGG>, IDeepCloneable<LKJMLPJEPGG>, IBufferMessage
{
	private static readonly MessageParser<LKJMLPJEPGG> _parser = new MessageParser<LKJMLPJEPGG>(() => new LKJMLPJEPGG());

	private UnknownFieldSet _unknownFields;

	public const int ILEMMKPGPNDFieldNumber = 3;

	private uint iLEMMKPGPND_;

	public const int HEIHGFAOFNKFieldNumber = 6;

	private uint hEIHGFAOFNK_;

	public const int ItemListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_itemList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> itemList_ = new RepeatedField<uint>();

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	public const int MNBPGMBLMJPFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_mNBPGMBLMJP_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> mNBPGMBLMJP_ = new RepeatedField<uint>();

	public const int FFBMMHAOHCAFieldNumber = 14;

	private bool fFBMMHAOHCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKJMLPJEPGG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKJMLPJEPGGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILEMMKPGPND
	{
		get
		{
			return iLEMMKPGPND_;
		}
		set
		{
			iLEMMKPGPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEIHGFAOFNK
	{
		get
		{
			return hEIHGFAOFNK_;
		}
		set
		{
			hEIHGFAOFNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ItemList => itemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MNBPGMBLMJP => mNBPGMBLMJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FFBMMHAOHCA
	{
		get
		{
			return fFBMMHAOHCA_;
		}
		set
		{
			fFBMMHAOHCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKJMLPJEPGG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKJMLPJEPGG(LKJMLPJEPGG other)
		: this()
	{
		iLEMMKPGPND_ = other.iLEMMKPGPND_;
		hEIHGFAOFNK_ = other.hEIHGFAOFNK_;
		itemList_ = other.itemList_.Clone();
		uniqueId_ = other.uniqueId_;
		mNBPGMBLMJP_ = other.mNBPGMBLMJP_.Clone();
		fFBMMHAOHCA_ = other.fFBMMHAOHCA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKJMLPJEPGG Clone()
	{
		return new LKJMLPJEPGG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKJMLPJEPGG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKJMLPJEPGG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ILEMMKPGPND != other.ILEMMKPGPND)
		{
			return false;
		}
		if (HEIHGFAOFNK != other.HEIHGFAOFNK)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!mNBPGMBLMJP_.Equals(other.mNBPGMBLMJP_))
		{
			return false;
		}
		if (FFBMMHAOHCA != other.FFBMMHAOHCA)
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
		if (ILEMMKPGPND != 0)
		{
			num ^= ILEMMKPGPND.GetHashCode();
		}
		if (HEIHGFAOFNK != 0)
		{
			num ^= HEIHGFAOFNK.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= mNBPGMBLMJP_.GetHashCode();
		if (FFBMMHAOHCA)
		{
			num ^= FFBMMHAOHCA.GetHashCode();
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
		if (ILEMMKPGPND != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ILEMMKPGPND);
		}
		if (HEIHGFAOFNK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HEIHGFAOFNK);
		}
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
		}
		mNBPGMBLMJP_.WriteTo(ref output, _repeated_mNBPGMBLMJP_codec);
		if (FFBMMHAOHCA)
		{
			output.WriteRawTag(112);
			output.WriteBool(FFBMMHAOHCA);
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
		if (ILEMMKPGPND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILEMMKPGPND);
		}
		if (HEIHGFAOFNK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEIHGFAOFNK);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += mNBPGMBLMJP_.CalculateSize(_repeated_mNBPGMBLMJP_codec);
		if (FFBMMHAOHCA)
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
	public void MergeFrom(LKJMLPJEPGG other)
	{
		if (other != null)
		{
			if (other.ILEMMKPGPND != 0)
			{
				ILEMMKPGPND = other.ILEMMKPGPND;
			}
			if (other.HEIHGFAOFNK != 0)
			{
				HEIHGFAOFNK = other.HEIHGFAOFNK;
			}
			itemList_.Add(other.itemList_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			mNBPGMBLMJP_.Add(other.mNBPGMBLMJP_);
			if (other.FFBMMHAOHCA)
			{
				FFBMMHAOHCA = other.FFBMMHAOHCA;
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
			case 24u:
				ILEMMKPGPND = input.ReadUInt32();
				break;
			case 48u:
				HEIHGFAOFNK = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				mNBPGMBLMJP_.AddEntriesFrom(ref input, _repeated_mNBPGMBLMJP_codec);
				break;
			case 112u:
				FFBMMHAOHCA = input.ReadBool();
				break;
			}
		}
	}
}
