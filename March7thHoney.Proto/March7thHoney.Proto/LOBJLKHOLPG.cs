using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOBJLKHOLPG : IMessage<LOBJLKHOLPG>, IMessage, IEquatable<LOBJLKHOLPG>, IDeepCloneable<LOBJLKHOLPG>, IBufferMessage
{
	private static readonly MessageParser<LOBJLKHOLPG> _parser = new MessageParser<LOBJLKHOLPG>(() => new LOBJLKHOLPG());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<PKJGGAPLONC> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, PKJGGAPLONC.Parser);

	private readonly RepeatedField<PKJGGAPLONC> avatarList_ = new RepeatedField<PKJGGAPLONC>();

	public const int FinishedTargetListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_finishedTargetList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> finishedTargetList_ = new RepeatedField<uint>();

	public const int PeakIdFieldNumber = 11;

	private uint peakId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOBJLKHOLPG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOBJLKHOLPGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PKJGGAPLONC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedTargetList => finishedTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PeakId
	{
		get
		{
			return peakId_;
		}
		set
		{
			peakId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOBJLKHOLPG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOBJLKHOLPG(LOBJLKHOLPG other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		finishedTargetList_ = other.finishedTargetList_.Clone();
		peakId_ = other.peakId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOBJLKHOLPG Clone()
	{
		return new LOBJLKHOLPG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOBJLKHOLPG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOBJLKHOLPG other)
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
		if (!finishedTargetList_.Equals(other.finishedTargetList_))
		{
			return false;
		}
		if (PeakId != other.PeakId)
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
		num ^= finishedTargetList_.GetHashCode();
		if (PeakId != 0)
		{
			num ^= PeakId.GetHashCode();
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
		finishedTargetList_.WriteTo(ref output, _repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PeakId);
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
		num += finishedTargetList_.CalculateSize(_repeated_finishedTargetList_codec);
		if (PeakId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOBJLKHOLPG other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			finishedTargetList_.Add(other.finishedTargetList_);
			if (other.PeakId != 0)
			{
				PeakId = other.PeakId;
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
			case 72u:
			case 74u:
				finishedTargetList_.AddEntriesFrom(ref input, _repeated_finishedTargetList_codec);
				break;
			case 88u:
				PeakId = input.ReadUInt32();
				break;
			}
		}
	}
}
