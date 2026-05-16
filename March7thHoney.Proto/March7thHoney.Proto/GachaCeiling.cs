using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GachaCeiling : IMessage<GachaCeiling>, IMessage, IEquatable<GachaCeiling>, IDeepCloneable<GachaCeiling>, IBufferMessage
{
	private static readonly MessageParser<GachaCeiling> _parser = new MessageParser<GachaCeiling>(() => new GachaCeiling());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 8;

	private static readonly FieldCodec<GachaCeilingAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(66u, GachaCeilingAvatar.Parser);

	private readonly RepeatedField<GachaCeilingAvatar> avatarList_ = new RepeatedField<GachaCeilingAvatar>();

	public const int CeilingNumFieldNumber = 11;

	private uint ceilingNum_;

	public const int IsClaimedFieldNumber = 15;

	private bool isClaimed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaCeiling> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaCeilingReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaCeilingAvatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CeilingNum
	{
		get
		{
			return ceilingNum_;
		}
		set
		{
			ceilingNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsClaimed
	{
		get
		{
			return isClaimed_;
		}
		set
		{
			isClaimed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaCeiling()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaCeiling(GachaCeiling other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		ceilingNum_ = other.ceilingNum_;
		isClaimed_ = other.isClaimed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaCeiling Clone()
	{
		return new GachaCeiling(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaCeiling);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaCeiling other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (CeilingNum != other.CeilingNum)
		{
			return false;
		}
		if (IsClaimed != other.IsClaimed)
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
		num ^= avatarList_.GetHashCode();
		if (CeilingNum != 0)
		{
			num ^= CeilingNum.GetHashCode();
		}
		if (IsClaimed)
		{
			num ^= IsClaimed.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (CeilingNum != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CeilingNum);
		}
		if (IsClaimed)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsClaimed);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (CeilingNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CeilingNum);
		}
		if (IsClaimed)
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
	public void MergeFrom(GachaCeiling other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.CeilingNum != 0)
			{
				CeilingNum = other.CeilingNum;
			}
			if (other.IsClaimed)
			{
				IsClaimed = other.IsClaimed;
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
			case 66u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 88u:
				CeilingNum = input.ReadUInt32();
				break;
			case 120u:
				IsClaimed = input.ReadBool();
				break;
			}
		}
	}
}
