using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PFBKJICJGBI : IMessage<PFBKJICJGBI>, IMessage, IEquatable<PFBKJICJGBI>, IDeepCloneable<PFBKJICJGBI>, IBufferMessage
{
	private static readonly MessageParser<PFBKJICJGBI> _parser = new MessageParser<PFBKJICJGBI>(() => new PFBKJICJGBI());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int GHMJCDADNIAFieldNumber = 2;

	private static readonly FieldCodec<FCMCJAKGPCG> _repeated_gHMJCDADNIA_codec = FieldCodec.ForMessage(18u, FCMCJAKGPCG.Parser);

	private readonly RepeatedField<FCMCJAKGPCG> gHMJCDADNIA_ = new RepeatedField<FCMCJAKGPCG>();

	public const int SlotFieldNumber = 3;

	private uint slot_;

	public const int MAONLHBKOFKFieldNumber = 4;

	private uint mAONLHBKOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PFBKJICJGBI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PFBKJICJGBIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FCMCJAKGPCG> GHMJCDADNIA => gHMJCDADNIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAONLHBKOFK
	{
		get
		{
			return mAONLHBKOFK_;
		}
		set
		{
			mAONLHBKOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFBKJICJGBI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFBKJICJGBI(PFBKJICJGBI other)
		: this()
	{
		avatarId_ = other.avatarId_;
		gHMJCDADNIA_ = other.gHMJCDADNIA_.Clone();
		slot_ = other.slot_;
		mAONLHBKOFK_ = other.mAONLHBKOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFBKJICJGBI Clone()
	{
		return new PFBKJICJGBI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PFBKJICJGBI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PFBKJICJGBI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!gHMJCDADNIA_.Equals(other.gHMJCDADNIA_))
		{
			return false;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (MAONLHBKOFK != other.MAONLHBKOFK)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= gHMJCDADNIA_.GetHashCode();
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (MAONLHBKOFK != 0)
		{
			num ^= MAONLHBKOFK.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		gHMJCDADNIA_.WriteTo(ref output, _repeated_gHMJCDADNIA_codec);
		if (Slot != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Slot);
		}
		if (MAONLHBKOFK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MAONLHBKOFK);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += gHMJCDADNIA_.CalculateSize(_repeated_gHMJCDADNIA_codec);
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (MAONLHBKOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAONLHBKOFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PFBKJICJGBI other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			gHMJCDADNIA_.Add(other.gHMJCDADNIA_);
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.MAONLHBKOFK != 0)
			{
				MAONLHBKOFK = other.MAONLHBKOFK;
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
			case 8u:
				AvatarId = input.ReadUInt32();
				break;
			case 18u:
				gHMJCDADNIA_.AddEntriesFrom(ref input, _repeated_gHMJCDADNIA_codec);
				break;
			case 24u:
				Slot = input.ReadUInt32();
				break;
			case 32u:
				MAONLHBKOFK = input.ReadUInt32();
				break;
			}
		}
	}
}
