using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOIKKHJLKJF : IMessage<AOIKKHJLKJF>, IMessage, IEquatable<AOIKKHJLKJF>, IDeepCloneable<AOIKKHJLKJF>, IBufferMessage
{
	private static readonly MessageParser<AOIKKHJLKJF> _parser = new MessageParser<AOIKKHJLKJF>(() => new AOIKKHJLKJF());

	private UnknownFieldSet _unknownFields;

	public const int KBJAHFLOOIJFieldNumber = 3;

	private bool kBJAHFLOOIJ_;

	public const int APMIAKDPHJLFieldNumber = 4;

	private uint aPMIAKDPHJL_;

	public const int ReasonFieldNumber = 6;

	private BEPLPKEFEED reason_;

	public const int PNNKFBILIEHFieldNumber = 9;

	private bool pNNKFBILIEH_;

	public const int ELIGJDHJEACFieldNumber = 10;

	private NEJMKCOKHOF eLIGJDHJEAC_;

	public const int FHLJEHDHJLIFieldNumber = 12;

	private static readonly FieldCodec<APBOFCPJCAF> _repeated_fHLJEHDHJLI_codec = FieldCodec.ForMessage(98u, APBOFCPJCAF.Parser);

	private readonly RepeatedField<APBOFCPJCAF> fHLJEHDHJLI_ = new RepeatedField<APBOFCPJCAF>();

	public const int StatusFieldNumber = 13;

	private RogueTournLevelStatus status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOIKKHJLKJF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOIKKHJLKJFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KBJAHFLOOIJ
	{
		get
		{
			return kBJAHFLOOIJ_;
		}
		set
		{
			kBJAHFLOOIJ_ = value;
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
	public bool PNNKFBILIEH
	{
		get
		{
			return pNNKFBILIEH_;
		}
		set
		{
			pNNKFBILIEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJMKCOKHOF ELIGJDHJEAC
	{
		get
		{
			return eLIGJDHJEAC_;
		}
		set
		{
			eLIGJDHJEAC_ = value;
		}
	}

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
	public AOIKKHJLKJF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKKHJLKJF(AOIKKHJLKJF other)
		: this()
	{
		kBJAHFLOOIJ_ = other.kBJAHFLOOIJ_;
		aPMIAKDPHJL_ = other.aPMIAKDPHJL_;
		reason_ = other.reason_;
		pNNKFBILIEH_ = other.pNNKFBILIEH_;
		eLIGJDHJEAC_ = ((other.eLIGJDHJEAC_ != null) ? other.eLIGJDHJEAC_.Clone() : null);
		fHLJEHDHJLI_ = other.fHLJEHDHJLI_.Clone();
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOIKKHJLKJF Clone()
	{
		return new AOIKKHJLKJF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOIKKHJLKJF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOIKKHJLKJF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBJAHFLOOIJ != other.KBJAHFLOOIJ)
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
		if (PNNKFBILIEH != other.PNNKFBILIEH)
		{
			return false;
		}
		if (!object.Equals(ELIGJDHJEAC, other.ELIGJDHJEAC))
		{
			return false;
		}
		if (!fHLJEHDHJLI_.Equals(other.fHLJEHDHJLI_))
		{
			return false;
		}
		if (Status != other.Status)
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
		if (KBJAHFLOOIJ)
		{
			num ^= KBJAHFLOOIJ.GetHashCode();
		}
		if (APMIAKDPHJL != 0)
		{
			num ^= APMIAKDPHJL.GetHashCode();
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
		}
		if (PNNKFBILIEH)
		{
			num ^= PNNKFBILIEH.GetHashCode();
		}
		if (eLIGJDHJEAC_ != null)
		{
			num ^= ELIGJDHJEAC.GetHashCode();
		}
		num ^= fHLJEHDHJLI_.GetHashCode();
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
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
		if (KBJAHFLOOIJ)
		{
			output.WriteRawTag(24);
			output.WriteBool(KBJAHFLOOIJ);
		}
		if (APMIAKDPHJL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(APMIAKDPHJL);
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Reason);
		}
		if (PNNKFBILIEH)
		{
			output.WriteRawTag(72);
			output.WriteBool(PNNKFBILIEH);
		}
		if (eLIGJDHJEAC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ELIGJDHJEAC);
		}
		fHLJEHDHJLI_.WriteTo(ref output, _repeated_fHLJEHDHJLI_codec);
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)Status);
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
		if (KBJAHFLOOIJ)
		{
			num += 2;
		}
		if (APMIAKDPHJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APMIAKDPHJL);
		}
		if (Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (PNNKFBILIEH)
		{
			num += 2;
		}
		if (eLIGJDHJEAC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELIGJDHJEAC);
		}
		num += fHLJEHDHJLI_.CalculateSize(_repeated_fHLJEHDHJLI_codec);
		if (Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOIKKHJLKJF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KBJAHFLOOIJ)
		{
			KBJAHFLOOIJ = other.KBJAHFLOOIJ;
		}
		if (other.APMIAKDPHJL != 0)
		{
			APMIAKDPHJL = other.APMIAKDPHJL;
		}
		if (other.Reason != BEPLPKEFEED.Pcpdhelpkem)
		{
			Reason = other.Reason;
		}
		if (other.PNNKFBILIEH)
		{
			PNNKFBILIEH = other.PNNKFBILIEH;
		}
		if (other.eLIGJDHJEAC_ != null)
		{
			if (eLIGJDHJEAC_ == null)
			{
				ELIGJDHJEAC = new NEJMKCOKHOF();
			}
			ELIGJDHJEAC.MergeFrom(other.ELIGJDHJEAC);
		}
		fHLJEHDHJLI_.Add(other.fHLJEHDHJLI_);
		if (other.Status != RogueTournLevelStatus.JppiekobpiiPcpdhelpkem)
		{
			Status = other.Status;
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
			case 24u:
				KBJAHFLOOIJ = input.ReadBool();
				break;
			case 32u:
				APMIAKDPHJL = input.ReadUInt32();
				break;
			case 48u:
				Reason = (BEPLPKEFEED)input.ReadEnum();
				break;
			case 72u:
				PNNKFBILIEH = input.ReadBool();
				break;
			case 82u:
				if (eLIGJDHJEAC_ == null)
				{
					ELIGJDHJEAC = new NEJMKCOKHOF();
				}
				input.ReadMessage(ELIGJDHJEAC);
				break;
			case 98u:
				fHLJEHDHJLI_.AddEntriesFrom(ref input, _repeated_fHLJEHDHJLI_codec);
				break;
			case 104u:
				Status = (RogueTournLevelStatus)input.ReadEnum();
				break;
			}
		}
	}
}
