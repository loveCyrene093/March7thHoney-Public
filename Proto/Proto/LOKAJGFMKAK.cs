using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOKAJGFMKAK : IMessage<LOKAJGFMKAK>, IMessage, IEquatable<LOKAJGFMKAK>, IDeepCloneable<LOKAJGFMKAK>, IBufferMessage
{
	private static readonly MessageParser<LOKAJGFMKAK> _parser = new MessageParser<LOKAJGFMKAK>(() => new LOKAJGFMKAK());

	private UnknownFieldSet _unknownFields;

	public const int IHJGLGCLANMFieldNumber = 2;

	private string iHJGLGCLANM_ = "";

	public const int IpFieldNumber = 6;

	private string ip_ = "";

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int EIFFDNNBGMCFieldNumber = 9;

	private ulong eIFFDNNBGMC_;

	public const int PortFieldNumber = 14;

	private uint port_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOKAJGFMKAK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOKAJGFMKAKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IHJGLGCLANM
	{
		get
		{
			return iHJGLGCLANM_;
		}
		set
		{
			iHJGLGCLANM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public ulong EIFFDNNBGMC
	{
		get
		{
			return eIFFDNNBGMC_;
		}
		set
		{
			eIFFDNNBGMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Port
	{
		get
		{
			return port_;
		}
		set
		{
			port_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOKAJGFMKAK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOKAJGFMKAK(LOKAJGFMKAK other)
		: this()
	{
		iHJGLGCLANM_ = other.iHJGLGCLANM_;
		ip_ = other.ip_;
		retcode_ = other.retcode_;
		eIFFDNNBGMC_ = other.eIFFDNNBGMC_;
		port_ = other.port_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOKAJGFMKAK Clone()
	{
		return new LOKAJGFMKAK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOKAJGFMKAK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOKAJGFMKAK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHJGLGCLANM != other.IHJGLGCLANM)
		{
			return false;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EIFFDNNBGMC != other.EIFFDNNBGMC)
		{
			return false;
		}
		if (Port != other.Port)
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
		if (IHJGLGCLANM.Length != 0)
		{
			num ^= IHJGLGCLANM.GetHashCode();
		}
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EIFFDNNBGMC != 0L)
		{
			num ^= EIFFDNNBGMC.GetHashCode();
		}
		if (Port != 0)
		{
			num ^= Port.GetHashCode();
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
		if (IHJGLGCLANM.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(IHJGLGCLANM);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Ip);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (EIFFDNNBGMC != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(EIFFDNNBGMC);
		}
		if (Port != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Port);
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
		if (IHJGLGCLANM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IHJGLGCLANM);
		}
		if (Ip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EIFFDNNBGMC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EIFFDNNBGMC);
		}
		if (Port != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Port);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOKAJGFMKAK other)
	{
		if (other != null)
		{
			if (other.IHJGLGCLANM.Length != 0)
			{
				IHJGLGCLANM = other.IHJGLGCLANM;
			}
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EIFFDNNBGMC != 0L)
			{
				EIFFDNNBGMC = other.EIFFDNNBGMC;
			}
			if (other.Port != 0)
			{
				Port = other.Port;
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
				IHJGLGCLANM = input.ReadString();
				break;
			case 50u:
				Ip = input.ReadString();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				EIFFDNNBGMC = input.ReadUInt64();
				break;
			case 112u:
				Port = input.ReadUInt32();
				break;
			}
		}
	}
}
