using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJOFAKOFLAM : IMessage<BJOFAKOFLAM>, IMessage, IEquatable<BJOFAKOFLAM>, IDeepCloneable<BJOFAKOFLAM>, IBufferMessage
{
	private static readonly MessageParser<BJOFAKOFLAM> _parser = new MessageParser<BJOFAKOFLAM>(() => new BJOFAKOFLAM());

	private UnknownFieldSet _unknownFields;

	public const int DCPKPNLKGMMFieldNumber = 5;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJOFAKOFLAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJOFAKOFLAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOFAKOFLAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOFAKOFLAM(BJOFAKOFLAM other)
		: this()
	{
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOFAKOFLAM Clone()
	{
		return new BJOFAKOFLAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJOFAKOFLAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJOFAKOFLAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
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
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
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
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DCPKPNLKGMM);
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
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJOFAKOFLAM other)
	{
		if (other != null)
		{
			if (other.DCPKPNLKGMM != 0)
			{
				DCPKPNLKGMM = other.DCPKPNLKGMM;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DCPKPNLKGMM = input.ReadUInt32();
			}
		}
	}
}
