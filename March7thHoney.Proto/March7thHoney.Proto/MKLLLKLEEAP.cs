using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKLLLKLEEAP : IMessage<MKLLLKLEEAP>, IMessage, IEquatable<MKLLLKLEEAP>, IDeepCloneable<MKLLLKLEEAP>, IBufferMessage
{
	private static readonly MessageParser<MKLLLKLEEAP> _parser = new MessageParser<MKLLLKLEEAP>(() => new MKLLLKLEEAP());

	private UnknownFieldSet _unknownFields;

	public const int IJDMECLJEBDFieldNumber = 3;

	private uint iJDMECLJEBD_;

	public const int DKAEIDJMJCJFieldNumber = 8;

	private uint dKAEIDJMJCJ_;

	public const int MHFHODDBOPMFieldNumber = 12;

	private ECKIDLIFAFG mHFHODDBOPM_;

	public const int ReasonFieldNumber = 15;

	private FKANIBDJNKG reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKLLLKLEEAP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKLLLKLEEAPReflection.Descriptor.MessageTypes[0];

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
	public uint DKAEIDJMJCJ
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
	public MKLLLKLEEAP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKLLLKLEEAP(MKLLLKLEEAP other)
		: this()
	{
		iJDMECLJEBD_ = other.iJDMECLJEBD_;
		dKAEIDJMJCJ_ = other.dKAEIDJMJCJ_;
		mHFHODDBOPM_ = ((other.mHFHODDBOPM_ != null) ? other.mHFHODDBOPM_.Clone() : null);
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKLLLKLEEAP Clone()
	{
		return new MKLLLKLEEAP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKLLLKLEEAP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKLLLKLEEAP other)
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
		if (DKAEIDJMJCJ != other.DKAEIDJMJCJ)
		{
			return false;
		}
		if (!object.Equals(MHFHODDBOPM, other.MHFHODDBOPM))
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
		if (IJDMECLJEBD != 0)
		{
			num ^= IJDMECLJEBD.GetHashCode();
		}
		if (DKAEIDJMJCJ != 0)
		{
			num ^= DKAEIDJMJCJ.GetHashCode();
		}
		if (mHFHODDBOPM_ != null)
		{
			num ^= MHFHODDBOPM.GetHashCode();
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
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
		if (IJDMECLJEBD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IJDMECLJEBD);
		}
		if (DKAEIDJMJCJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DKAEIDJMJCJ);
		}
		if (mHFHODDBOPM_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(MHFHODDBOPM);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
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
		if (IJDMECLJEBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJDMECLJEBD);
		}
		if (DKAEIDJMJCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKAEIDJMJCJ);
		}
		if (mHFHODDBOPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MHFHODDBOPM);
		}
		if (Reason != FKANIBDJNKG.Ofghjkihmib)
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
	public void MergeFrom(MKLLLKLEEAP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IJDMECLJEBD != 0)
		{
			IJDMECLJEBD = other.IJDMECLJEBD;
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
		if (other.Reason != FKANIBDJNKG.Ofghjkihmib)
		{
			Reason = other.Reason;
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
			case 64u:
				DKAEIDJMJCJ = input.ReadUInt32();
				break;
			case 98u:
				if (mHFHODDBOPM_ == null)
				{
					MHFHODDBOPM = new ECKIDLIFAFG();
				}
				input.ReadMessage(MHFHODDBOPM);
				break;
			case 120u:
				Reason = (FKANIBDJNKG)input.ReadEnum();
				break;
			}
		}
	}
}
