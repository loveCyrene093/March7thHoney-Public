using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OAMHEIJBIKG : IMessage<OAMHEIJBIKG>, IMessage, IEquatable<OAMHEIJBIKG>, IDeepCloneable<OAMHEIJBIKG>, IBufferMessage
{
	private static readonly MessageParser<OAMHEIJBIKG> _parser = new MessageParser<OAMHEIJBIKG>(() => new OAMHEIJBIKG());

	private UnknownFieldSet _unknownFields;

	public const int DAFENDGOABEFieldNumber = 1;

	private uint dAFENDGOABE_;

	public const int CAHDOOIHJKBFieldNumber = 4;

	private uint cAHDOOIHJKB_;

	public const int RewardListFieldNumber = 9;

	private ItemList rewardList_;

	public const int ProgressFieldNumber = 10;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OAMHEIJBIKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OAMHEIJBIKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DAFENDGOABE
	{
		get
		{
			return dAFENDGOABE_;
		}
		set
		{
			dAFENDGOABE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CAHDOOIHJKB
	{
		get
		{
			return cAHDOOIHJKB_;
		}
		set
		{
			cAHDOOIHJKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList RewardList
	{
		get
		{
			return rewardList_;
		}
		set
		{
			rewardList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMHEIJBIKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMHEIJBIKG(OAMHEIJBIKG other)
		: this()
	{
		dAFENDGOABE_ = other.dAFENDGOABE_;
		cAHDOOIHJKB_ = other.cAHDOOIHJKB_;
		rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAMHEIJBIKG Clone()
	{
		return new OAMHEIJBIKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OAMHEIJBIKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OAMHEIJBIKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DAFENDGOABE != other.DAFENDGOABE)
		{
			return false;
		}
		if (CAHDOOIHJKB != other.CAHDOOIHJKB)
		{
			return false;
		}
		if (!object.Equals(RewardList, other.RewardList))
		{
			return false;
		}
		if (Progress != other.Progress)
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
		if (DAFENDGOABE != 0)
		{
			num ^= DAFENDGOABE.GetHashCode();
		}
		if (CAHDOOIHJKB != 0)
		{
			num ^= CAHDOOIHJKB.GetHashCode();
		}
		if (rewardList_ != null)
		{
			num ^= RewardList.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		if (DAFENDGOABE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DAFENDGOABE);
		}
		if (CAHDOOIHJKB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CAHDOOIHJKB);
		}
		if (rewardList_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RewardList);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Progress);
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
		if (DAFENDGOABE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DAFENDGOABE);
		}
		if (CAHDOOIHJKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CAHDOOIHJKB);
		}
		if (rewardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardList);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OAMHEIJBIKG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DAFENDGOABE != 0)
		{
			DAFENDGOABE = other.DAFENDGOABE;
		}
		if (other.CAHDOOIHJKB != 0)
		{
			CAHDOOIHJKB = other.CAHDOOIHJKB;
		}
		if (other.rewardList_ != null)
		{
			if (rewardList_ == null)
			{
				RewardList = new ItemList();
			}
			RewardList.MergeFrom(other.RewardList);
		}
		if (other.Progress != 0)
		{
			Progress = other.Progress;
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
				DAFENDGOABE = input.ReadUInt32();
				break;
			case 32u:
				CAHDOOIHJKB = input.ReadUInt32();
				break;
			case 74u:
				if (rewardList_ == null)
				{
					RewardList = new ItemList();
				}
				input.ReadMessage(RewardList);
				break;
			case 80u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
