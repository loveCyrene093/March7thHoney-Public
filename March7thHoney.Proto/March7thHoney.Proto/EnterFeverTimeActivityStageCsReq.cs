using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterFeverTimeActivityStageCsReq : IMessage<EnterFeverTimeActivityStageCsReq>, IMessage, IEquatable<EnterFeverTimeActivityStageCsReq>, IDeepCloneable<EnterFeverTimeActivityStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterFeverTimeActivityStageCsReq> _parser = new MessageParser<EnterFeverTimeActivityStageCsReq>(() => new EnterFeverTimeActivityStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<HAJAOGGPCJC> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, HAJAOGGPCJC.Parser);

	private readonly RepeatedField<HAJAOGGPCJC> avatarList_ = new RepeatedField<HAJAOGGPCJC>();

	public const int MBNNAGEIAAHFieldNumber = 5;

	private uint mBNNAGEIAAH_;

	public const int IdFieldNumber = 8;

	private uint id_;

	public const int GDBOODKLBMKFieldNumber = 13;

	private uint gDBOODKLBMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterFeverTimeActivityStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterFeverTimeActivityStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HAJAOGGPCJC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBNNAGEIAAH
	{
		get
		{
			return mBNNAGEIAAH_;
		}
		set
		{
			mBNNAGEIAAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDBOODKLBMK
	{
		get
		{
			return gDBOODKLBMK_;
		}
		set
		{
			gDBOODKLBMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterFeverTimeActivityStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterFeverTimeActivityStageCsReq(EnterFeverTimeActivityStageCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		mBNNAGEIAAH_ = other.mBNNAGEIAAH_;
		id_ = other.id_;
		gDBOODKLBMK_ = other.gDBOODKLBMK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterFeverTimeActivityStageCsReq Clone()
	{
		return new EnterFeverTimeActivityStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterFeverTimeActivityStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterFeverTimeActivityStageCsReq other)
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
		if (MBNNAGEIAAH != other.MBNNAGEIAAH)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (GDBOODKLBMK != other.GDBOODKLBMK)
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
		if (MBNNAGEIAAH != 0)
		{
			num ^= MBNNAGEIAAH.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (GDBOODKLBMK != 0)
		{
			num ^= GDBOODKLBMK.GetHashCode();
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
		if (MBNNAGEIAAH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MBNNAGEIAAH);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Id);
		}
		if (GDBOODKLBMK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GDBOODKLBMK);
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
		if (MBNNAGEIAAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBNNAGEIAAH);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (GDBOODKLBMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDBOODKLBMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterFeverTimeActivityStageCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.MBNNAGEIAAH != 0)
			{
				MBNNAGEIAAH = other.MBNNAGEIAAH;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.GDBOODKLBMK != 0)
			{
				GDBOODKLBMK = other.GDBOODKLBMK;
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 40u:
				MBNNAGEIAAH = input.ReadUInt32();
				break;
			case 64u:
				Id = input.ReadUInt32();
				break;
			case 104u:
				GDBOODKLBMK = input.ReadUInt32();
				break;
			}
		}
	}
}
