using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LACLGMFHPFG : IMessage<LACLGMFHPFG>, IMessage, IEquatable<LACLGMFHPFG>, IDeepCloneable<LACLGMFHPFG>, IBufferMessage
{
	private static readonly MessageParser<LACLGMFHPFG> _parser = new MessageParser<LACLGMFHPFG>(() => new LACLGMFHPFG());

	private UnknownFieldSet _unknownFields;

	public const int LMPIBBNFKMCFieldNumber = 12;

	private bool lMPIBBNFKMC_;

	public const int GODDNDPMBIKFieldNumber = 13;

	private bool gODDNDPMBIK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LACLGMFHPFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LACLGMFHPFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LMPIBBNFKMC
	{
		get
		{
			return lMPIBBNFKMC_;
		}
		set
		{
			lMPIBBNFKMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GODDNDPMBIK
	{
		get
		{
			return gODDNDPMBIK_;
		}
		set
		{
			gODDNDPMBIK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LACLGMFHPFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LACLGMFHPFG(LACLGMFHPFG other)
		: this()
	{
		lMPIBBNFKMC_ = other.lMPIBBNFKMC_;
		gODDNDPMBIK_ = other.gODDNDPMBIK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LACLGMFHPFG Clone()
	{
		return new LACLGMFHPFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LACLGMFHPFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LACLGMFHPFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LMPIBBNFKMC != other.LMPIBBNFKMC)
		{
			return false;
		}
		if (GODDNDPMBIK != other.GODDNDPMBIK)
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
		if (LMPIBBNFKMC)
		{
			num ^= LMPIBBNFKMC.GetHashCode();
		}
		if (GODDNDPMBIK)
		{
			num ^= GODDNDPMBIK.GetHashCode();
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
		if (LMPIBBNFKMC)
		{
			output.WriteRawTag(96);
			output.WriteBool(LMPIBBNFKMC);
		}
		if (GODDNDPMBIK)
		{
			output.WriteRawTag(104);
			output.WriteBool(GODDNDPMBIK);
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
		if (LMPIBBNFKMC)
		{
			num += 2;
		}
		if (GODDNDPMBIK)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LACLGMFHPFG other)
	{
		if (other != null)
		{
			if (other.LMPIBBNFKMC)
			{
				LMPIBBNFKMC = other.LMPIBBNFKMC;
			}
			if (other.GODDNDPMBIK)
			{
				GODDNDPMBIK = other.GODDNDPMBIK;
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
			case 96u:
				LMPIBBNFKMC = input.ReadBool();
				break;
			case 104u:
				GODDNDPMBIK = input.ReadBool();
				break;
			}
		}
	}
}
