using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueSelectCellScRsp : IMessage<ChessRogueSelectCellScRsp>, IMessage, IEquatable<ChessRogueSelectCellScRsp>, IDeepCloneable<ChessRogueSelectCellScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueSelectCellScRsp> _parser = new MessageParser<ChessRogueSelectCellScRsp>(() => new ChessRogueSelectCellScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JNLNMHOOEKLFieldNumber = 5;

	private uint jNLNMHOOEKL_;

	public const int EIIAGABAFECFieldNumber = 6;

	private uint eIIAGABAFEC_;

	public const int KAEALLELADNFieldNumber = 8;

	private BJHDDMCFAMF kAEALLELADN_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueSelectCellScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueSelectCellScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNLNMHOOEKL
	{
		get
		{
			return jNLNMHOOEKL_;
		}
		set
		{
			jNLNMHOOEKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJHDDMCFAMF KAEALLELADN
	{
		get
		{
			return kAEALLELADN_;
		}
		set
		{
			kAEALLELADN_ = value;
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
	public ChessRogueSelectCellScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueSelectCellScRsp(ChessRogueSelectCellScRsp other)
		: this()
	{
		jNLNMHOOEKL_ = other.jNLNMHOOEKL_;
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		kAEALLELADN_ = ((other.kAEALLELADN_ != null) ? other.kAEALLELADN_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueSelectCellScRsp Clone()
	{
		return new ChessRogueSelectCellScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueSelectCellScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueSelectCellScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JNLNMHOOEKL != other.JNLNMHOOEKL)
		{
			return false;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (!object.Equals(KAEALLELADN, other.KAEALLELADN))
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
		if (JNLNMHOOEKL != 0)
		{
			num ^= JNLNMHOOEKL.GetHashCode();
		}
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (kAEALLELADN_ != null)
		{
			num ^= KAEALLELADN.GetHashCode();
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
		if (JNLNMHOOEKL != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JNLNMHOOEKL);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (kAEALLELADN_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(KAEALLELADN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
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
		if (JNLNMHOOEKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNLNMHOOEKL);
		}
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (kAEALLELADN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KAEALLELADN);
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
	public void MergeFrom(ChessRogueSelectCellScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JNLNMHOOEKL != 0)
		{
			JNLNMHOOEKL = other.JNLNMHOOEKL;
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		if (other.kAEALLELADN_ != null)
		{
			if (kAEALLELADN_ == null)
			{
				KAEALLELADN = new BJHDDMCFAMF();
			}
			KAEALLELADN.MergeFrom(other.KAEALLELADN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 40u:
				JNLNMHOOEKL = input.ReadUInt32();
				break;
			case 48u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 66u:
				if (kAEALLELADN_ == null)
				{
					KAEALLELADN = new BJHDDMCFAMF();
				}
				input.ReadMessage(KAEALLELADN);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
