using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EvolveBuildShopAbilityResetCsReq : IMessage<EvolveBuildShopAbilityResetCsReq>, IMessage, IEquatable<EvolveBuildShopAbilityResetCsReq>, IDeepCloneable<EvolveBuildShopAbilityResetCsReq>, IBufferMessage
{
	private static readonly MessageParser<EvolveBuildShopAbilityResetCsReq> _parser = new MessageParser<EvolveBuildShopAbilityResetCsReq>(() => new EvolveBuildShopAbilityResetCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EGLCKGKECAJFieldNumber = 3;

	private GCHPNHBDCDO eGLCKGKECAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvolveBuildShopAbilityResetCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvolveBuildShopAbilityResetCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHPNHBDCDO EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityResetCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityResetCsReq(EvolveBuildShopAbilityResetCsReq other)
		: this()
	{
		eGLCKGKECAJ_ = other.eGLCKGKECAJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvolveBuildShopAbilityResetCsReq Clone()
	{
		return new EvolveBuildShopAbilityResetCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvolveBuildShopAbilityResetCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvolveBuildShopAbilityResetCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EGLCKGKECAJ != other.EGLCKGKECAJ)
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EGLCKGKECAJ);
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
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EGLCKGKECAJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvolveBuildShopAbilityResetCsReq other)
	{
		if (other != null)
		{
			if (other.EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
			{
				EGLCKGKECAJ = other.EGLCKGKECAJ;
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
			if (num != 24)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				EGLCKGKECAJ = (GCHPNHBDCDO)input.ReadEnum();
			}
		}
	}
}
