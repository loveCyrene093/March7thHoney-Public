using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncStatus : IMessage<SyncStatus>, IMessage, IEquatable<SyncStatus>, IDeepCloneable<SyncStatus>, IBufferMessage
{
	private static readonly MessageParser<SyncStatus> _parser = new MessageParser<SyncStatus>(() => new SyncStatus());

	private UnknownFieldSet _unknownFields;

	public const int SectionStatusFieldNumber = 3;

	private static readonly FieldCodec<SectionStatus> _repeated_sectionStatus_codec = FieldCodec.ForMessage(26u, March7thHoney.Proto.SectionStatus.Parser);

	private readonly RepeatedField<SectionStatus> sectionStatus_ = new RepeatedField<SectionStatus>();

	public const int CMEKBMAEHLDFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_cMEKBMAEHLD_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> cMEKBMAEHLD_ = new RepeatedField<uint>();

	public const int AFKCPLHIMGHFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_aFKCPLHIMGH_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> aFKCPLHIMGH_ = new RepeatedField<uint>();

	public const int MessageGroupStatusFieldNumber = 15;

	private static readonly FieldCodec<GroupStatus> _repeated_messageGroupStatus_codec = FieldCodec.ForMessage(122u, GroupStatus.Parser);

	private readonly RepeatedField<GroupStatus> messageGroupStatus_ = new RepeatedField<GroupStatus>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncStatus> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncStatusReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SectionStatus> SectionStatus => sectionStatus_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CMEKBMAEHLD => cMEKBMAEHLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AFKCPLHIMGH => aFKCPLHIMGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GroupStatus> MessageGroupStatus => messageGroupStatus_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncStatus()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncStatus(SyncStatus other)
		: this()
	{
		sectionStatus_ = other.sectionStatus_.Clone();
		cMEKBMAEHLD_ = other.cMEKBMAEHLD_.Clone();
		aFKCPLHIMGH_ = other.aFKCPLHIMGH_.Clone();
		messageGroupStatus_ = other.messageGroupStatus_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncStatus Clone()
	{
		return new SyncStatus(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncStatus);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!sectionStatus_.Equals(other.sectionStatus_))
		{
			return false;
		}
		if (!cMEKBMAEHLD_.Equals(other.cMEKBMAEHLD_))
		{
			return false;
		}
		if (!aFKCPLHIMGH_.Equals(other.aFKCPLHIMGH_))
		{
			return false;
		}
		if (!messageGroupStatus_.Equals(other.messageGroupStatus_))
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
		num ^= sectionStatus_.GetHashCode();
		num ^= cMEKBMAEHLD_.GetHashCode();
		num ^= aFKCPLHIMGH_.GetHashCode();
		num ^= messageGroupStatus_.GetHashCode();
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
		sectionStatus_.WriteTo(ref output, _repeated_sectionStatus_codec);
		cMEKBMAEHLD_.WriteTo(ref output, _repeated_cMEKBMAEHLD_codec);
		aFKCPLHIMGH_.WriteTo(ref output, _repeated_aFKCPLHIMGH_codec);
		messageGroupStatus_.WriteTo(ref output, _repeated_messageGroupStatus_codec);
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
		num += sectionStatus_.CalculateSize(_repeated_sectionStatus_codec);
		num += cMEKBMAEHLD_.CalculateSize(_repeated_cMEKBMAEHLD_codec);
		num += aFKCPLHIMGH_.CalculateSize(_repeated_aFKCPLHIMGH_codec);
		num += messageGroupStatus_.CalculateSize(_repeated_messageGroupStatus_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncStatus other)
	{
		if (other != null)
		{
			sectionStatus_.Add(other.sectionStatus_);
			cMEKBMAEHLD_.Add(other.cMEKBMAEHLD_);
			aFKCPLHIMGH_.Add(other.aFKCPLHIMGH_);
			messageGroupStatus_.Add(other.messageGroupStatus_);
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
			case 26u:
				sectionStatus_.AddEntriesFrom(ref input, _repeated_sectionStatus_codec);
				break;
			case 96u:
			case 98u:
				cMEKBMAEHLD_.AddEntriesFrom(ref input, _repeated_cMEKBMAEHLD_codec);
				break;
			case 112u:
			case 114u:
				aFKCPLHIMGH_.AddEntriesFrom(ref input, _repeated_aFKCPLHIMGH_codec);
				break;
			case 122u:
				messageGroupStatus_.AddEntriesFrom(ref input, _repeated_messageGroupStatus_codec);
				break;
			}
		}
	}
}
