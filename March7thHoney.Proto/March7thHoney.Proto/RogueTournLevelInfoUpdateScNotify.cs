using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournLevelInfoUpdateScNotify : IMessage<RogueTournLevelInfoUpdateScNotify>, IMessage, IEquatable<RogueTournLevelInfoUpdateScNotify>, IDeepCloneable<RogueTournLevelInfoUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournLevelInfoUpdateScNotify> _parser = new MessageParser<RogueTournLevelInfoUpdateScNotify>(() => new RogueTournLevelInfoUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FHLJEHDHJLIFieldNumber = 6;

	private static readonly FieldCodec<APBOFCPJCAF> _repeated_fHLJEHDHJLI_codec = FieldCodec.ForMessage(50u, APBOFCPJCAF.Parser);

	private readonly RepeatedField<APBOFCPJCAF> fHLJEHDHJLI_ = new RepeatedField<APBOFCPJCAF>();

	public const int StatusFieldNumber = 7;

	private RogueTournLevelStatus status_;

	public const int APMIAKDPHJLFieldNumber = 11;

	private uint aPMIAKDPHJL_;

	public const int ReasonFieldNumber = 15;

	private BEPLPKEFEED reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournLevelInfoUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournLevelInfoUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<APBOFCPJCAF> FHLJEHDHJLI => fHLJEHDHJLI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLevelStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APMIAKDPHJL
	{
		get
		{
			return aPMIAKDPHJL_;
		}
		set
		{
			aPMIAKDPHJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEPLPKEFEED Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLevelInfoUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLevelInfoUpdateScNotify(RogueTournLevelInfoUpdateScNotify other)
		: this()
	{
		fHLJEHDHJLI_ = other.fHLJEHDHJLI_.Clone();
		status_ = other.status_;
		aPMIAKDPHJL_ = other.aPMIAKDPHJL_;
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLevelInfoUpdateScNotify Clone()
	{
		return new RogueTournLevelInfoUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournLevelInfoUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournLevelInfoUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fHLJEHDHJLI_.Equals(other.fHLJEHDHJLI_))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (APMIAKDPHJL != other.APMIAKDPHJL)
		{
			return false;
		}
		if (Reason != other.Reason)
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
		num ^= fHLJEHDHJLI_.GetHashCode();
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (APMIAKDPHJL != 0)
		{
			num ^= APMIAKDPHJL.GetHashCode();
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
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
		fHLJEHDHJLI_.WriteTo(ref output, _repeated_fHLJEHDHJLI_codec);
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Status);
		}
		if (APMIAKDPHJL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(APMIAKDPHJL);
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Reason);
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
		num += fHLJEHDHJLI_.CalculateSize(_repeated_fHLJEHDHJLI_codec);
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (APMIAKDPHJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APMIAKDPHJL);
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournLevelInfoUpdateScNotify other)
	{
		if (other != null)
		{
			fHLJEHDHJLI_.Add(other.fHLJEHDHJLI_);
			if (other.Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.APMIAKDPHJL != 0)
			{
				APMIAKDPHJL = other.APMIAKDPHJL;
			}
			if (other.Reason != BEPLPKEFEED.Pcpdhelpkem)
			{
				Reason = other.Reason;
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
			case 50u:
				fHLJEHDHJLI_.AddEntriesFrom(ref input, _repeated_fHLJEHDHJLI_codec);
				break;
			case 56u:
				Status = (RogueTournLevelStatus)input.ReadEnum();
				break;
			case 88u:
				APMIAKDPHJL = input.ReadUInt32();
				break;
			case 120u:
				Reason = (BEPLPKEFEED)input.ReadEnum();
				break;
			}
		}
	}
}
