using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOGHKDGEFGA : IMessage<AOGHKDGEFGA>, IMessage, IEquatable<AOGHKDGEFGA>, IDeepCloneable<AOGHKDGEFGA>, IBufferMessage
{
	private static readonly MessageParser<AOGHKDGEFGA> _parser = new MessageParser<AOGHKDGEFGA>(() => new AOGHKDGEFGA());

	private UnknownFieldSet _unknownFields;

	public const int RelicPlanListFieldNumber = 2;

	private static readonly FieldCodec<NBMFOJAKMGP> _repeated_relicPlanList_codec = FieldCodec.ForMessage(18u, NBMFOJAKMGP.Parser);

	private readonly RepeatedField<NBMFOJAKMGP> relicPlanList_ = new RepeatedField<NBMFOJAKMGP>();

	public const int AvatarIdFieldNumber = 8;

	private uint avatarId_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOGHKDGEFGA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOGHKDGEFGAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBMFOJAKMGP> RelicPlanList => relicPlanList_;

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOGHKDGEFGA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOGHKDGEFGA(AOGHKDGEFGA other)
		: this()
	{
		relicPlanList_ = other.relicPlanList_.Clone();
		avatarId_ = other.avatarId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOGHKDGEFGA Clone()
	{
		return new AOGHKDGEFGA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOGHKDGEFGA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOGHKDGEFGA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!relicPlanList_.Equals(other.relicPlanList_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= relicPlanList_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		relicPlanList_.WriteTo(ref output, _repeated_relicPlanList_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AvatarId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
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
		num += relicPlanList_.CalculateSize(_repeated_relicPlanList_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOGHKDGEFGA other)
	{
		if (other != null)
		{
			relicPlanList_.Add(other.relicPlanList_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				relicPlanList_.AddEntriesFrom(ref input, _repeated_relicPlanList_codec);
				break;
			case 64u:
				AvatarId = input.ReadUInt32();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
