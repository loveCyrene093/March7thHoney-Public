using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MBCJAOHMNFD : IMessage<MBCJAOHMNFD>, IMessage, IEquatable<MBCJAOHMNFD>, IDeepCloneable<MBCJAOHMNFD>, IBufferMessage
{
	private static readonly MessageParser<MBCJAOHMNFD> _parser = new MessageParser<MBCJAOHMNFD>(() => new MBCJAOHMNFD());

	private UnknownFieldSet _unknownFields;

	public const int HasPassedFieldNumber = 1;

	private bool hasPassed_;

	public const int EventIdFieldNumber = 2;

	private uint eventId_;

	public const int HAAAPFLGNBMFieldNumber = 4;

	private uint hAAAPFLGNBM_;

	public const int BIMKHABLGMCFieldNumber = 10;

	private uint bIMKHABLGMC_;

	public const int LIFNGFJDEFDFieldNumber = 14;

	private uint lIFNGFJDEFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MBCJAOHMNFD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MBCJAOHMNFDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAAAPFLGNBM
	{
		get
		{
			return hAAAPFLGNBM_;
		}
		set
		{
			hAAAPFLGNBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BIMKHABLGMC
	{
		get
		{
			return bIMKHABLGMC_;
		}
		set
		{
			bIMKHABLGMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LIFNGFJDEFD
	{
		get
		{
			return lIFNGFJDEFD_;
		}
		set
		{
			lIFNGFJDEFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCJAOHMNFD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCJAOHMNFD(MBCJAOHMNFD other)
		: this()
	{
		hasPassed_ = other.hasPassed_;
		eventId_ = other.eventId_;
		hAAAPFLGNBM_ = other.hAAAPFLGNBM_;
		bIMKHABLGMC_ = other.bIMKHABLGMC_;
		lIFNGFJDEFD_ = other.lIFNGFJDEFD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBCJAOHMNFD Clone()
	{
		return new MBCJAOHMNFD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MBCJAOHMNFD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MBCJAOHMNFD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (HAAAPFLGNBM != other.HAAAPFLGNBM)
		{
			return false;
		}
		if (BIMKHABLGMC != other.BIMKHABLGMC)
		{
			return false;
		}
		if (LIFNGFJDEFD != other.LIFNGFJDEFD)
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
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (HAAAPFLGNBM != 0)
		{
			num ^= HAAAPFLGNBM.GetHashCode();
		}
		if (BIMKHABLGMC != 0)
		{
			num ^= BIMKHABLGMC.GetHashCode();
		}
		if (LIFNGFJDEFD != 0)
		{
			num ^= LIFNGFJDEFD.GetHashCode();
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
		if (HasPassed)
		{
			output.WriteRawTag(8);
			output.WriteBool(HasPassed);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EventId);
		}
		if (HAAAPFLGNBM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HAAAPFLGNBM);
		}
		if (BIMKHABLGMC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BIMKHABLGMC);
		}
		if (LIFNGFJDEFD != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LIFNGFJDEFD);
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
		if (HasPassed)
		{
			num += 2;
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (HAAAPFLGNBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAAAPFLGNBM);
		}
		if (BIMKHABLGMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIMKHABLGMC);
		}
		if (LIFNGFJDEFD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LIFNGFJDEFD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MBCJAOHMNFD other)
	{
		if (other != null)
		{
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.HAAAPFLGNBM != 0)
			{
				HAAAPFLGNBM = other.HAAAPFLGNBM;
			}
			if (other.BIMKHABLGMC != 0)
			{
				BIMKHABLGMC = other.BIMKHABLGMC;
			}
			if (other.LIFNGFJDEFD != 0)
			{
				LIFNGFJDEFD = other.LIFNGFJDEFD;
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
				HasPassed = input.ReadBool();
				break;
			case 16u:
				EventId = input.ReadUInt32();
				break;
			case 32u:
				HAAAPFLGNBM = input.ReadUInt32();
				break;
			case 80u:
				BIMKHABLGMC = input.ReadUInt32();
				break;
			case 112u:
				LIFNGFJDEFD = input.ReadUInt32();
				break;
			}
		}
	}
}
