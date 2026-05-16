using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMJGBJKNKPE : IMessage<HMJGBJKNKPE>, IMessage, IEquatable<HMJGBJKNKPE>, IDeepCloneable<HMJGBJKNKPE>, IBufferMessage
{
	private static readonly MessageParser<HMJGBJKNKPE> _parser = new MessageParser<HMJGBJKNKPE>(() => new HMJGBJKNKPE());

	private UnknownFieldSet _unknownFields;

	public const int IJDMECLJEBDFieldNumber = 3;

	private uint iJDMECLJEBD_;

	public const int BFCBGPEICHGFieldNumber = 4;

	private FightGameMode bFCBGPEICHG_;

	public const int ReasonFieldNumber = 9;

	private FKANIBDJNKG reason_;

	public const int DKAEIDJMJCJFieldNumber = 10;

	private int dKAEIDJMJCJ_;

	public const int MHFHODDBOPMFieldNumber = 11;

	private ECKIDLIFAFG mHFHODDBOPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMJGBJKNKPE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMJGBJKNKPEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJDMECLJEBD
	{
		get
		{
			return iJDMECLJEBD_;
		}
		set
		{
			iJDMECLJEBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode BFCBGPEICHG
	{
		get
		{
			return bFCBGPEICHG_;
		}
		set
		{
			bFCBGPEICHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKANIBDJNKG Reason
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
	public int DKAEIDJMJCJ
	{
		get
		{
			return dKAEIDJMJCJ_;
		}
		set
		{
			dKAEIDJMJCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECKIDLIFAFG MHFHODDBOPM
	{
		get
		{
			return mHFHODDBOPM_;
		}
		set
		{
			mHFHODDBOPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGBJKNKPE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGBJKNKPE(HMJGBJKNKPE other)
		: this()
	{
		iJDMECLJEBD_ = other.iJDMECLJEBD_;
		bFCBGPEICHG_ = other.bFCBGPEICHG_;
		reason_ = other.reason_;
		dKAEIDJMJCJ_ = other.dKAEIDJMJCJ_;
		mHFHODDBOPM_ = ((other.mHFHODDBOPM_ != null) ? other.mHFHODDBOPM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGBJKNKPE Clone()
	{
		return new HMJGBJKNKPE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMJGBJKNKPE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMJGBJKNKPE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IJDMECLJEBD != other.IJDMECLJEBD)
		{
			return false;
		}
		if (BFCBGPEICHG != other.BFCBGPEICHG)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (DKAEIDJMJCJ != other.DKAEIDJMJCJ)
		{
			return false;
		}
		if (!object.Equals(MHFHODDBOPM, other.MHFHODDBOPM))
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
		if (IJDMECLJEBD != 0)
		{
			num ^= IJDMECLJEBD.GetHashCode();
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= BFCBGPEICHG.GetHashCode();
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			num ^= Reason.GetHashCode();
		}
		if (DKAEIDJMJCJ != 0)
		{
			num ^= DKAEIDJMJCJ.GetHashCode();
		}
		if (mHFHODDBOPM_ != null)
		{
			num ^= MHFHODDBOPM.GetHashCode();
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
		if (IJDMECLJEBD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IJDMECLJEBD);
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BFCBGPEICHG);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)Reason);
		}
		if (DKAEIDJMJCJ != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(DKAEIDJMJCJ);
		}
		if (mHFHODDBOPM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MHFHODDBOPM);
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
		if (IJDMECLJEBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJDMECLJEBD);
		}
		if (BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BFCBGPEICHG);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (DKAEIDJMJCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DKAEIDJMJCJ);
		}
		if (mHFHODDBOPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHFHODDBOPM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMJGBJKNKPE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IJDMECLJEBD != 0)
		{
			IJDMECLJEBD = other.IJDMECLJEBD;
		}
		if (other.BFCBGPEICHG != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			BFCBGPEICHG = other.BFCBGPEICHG;
		}
		if (other.Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			Reason = other.Reason;
		}
		if (other.DKAEIDJMJCJ != 0)
		{
			DKAEIDJMJCJ = other.DKAEIDJMJCJ;
		}
		if (other.mHFHODDBOPM_ != null)
		{
			if (mHFHODDBOPM_ == null)
			{
				MHFHODDBOPM = new ECKIDLIFAFG();
			}
			MHFHODDBOPM.MergeFrom(other.MHFHODDBOPM);
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
				IJDMECLJEBD = input.ReadUInt32();
				break;
			case 32u:
				BFCBGPEICHG = (FightGameMode)input.ReadEnum();
				break;
			case 72u:
				Reason = (FKANIBDJNKG)input.ReadEnum();
				break;
			case 80u:
				DKAEIDJMJCJ = input.ReadInt32();
				break;
			case 90u:
				if (mHFHODDBOPM_ == null)
				{
					MHFHODDBOPM = new ECKIDLIFAFG();
				}
				input.ReadMessage(MHFHODDBOPM);
				break;
			}
		}
	}
}
