using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFLGMCDHAFM : IMessage<GFLGMCDHAFM>, IMessage, IEquatable<GFLGMCDHAFM>, IDeepCloneable<GFLGMCDHAFM>, IBufferMessage
{
	private static readonly MessageParser<GFLGMCDHAFM> _parser = new MessageParser<GFLGMCDHAFM>(() => new GFLGMCDHAFM());

	private UnknownFieldSet _unknownFields;

	public const int HDKHECHPIGJFieldNumber = 2;

	private JAFPMLLOGDI hDKHECHPIGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFLGMCDHAFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFLGMCDHAFMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFPMLLOGDI HDKHECHPIGJ
	{
		get
		{
			return hDKHECHPIGJ_;
		}
		set
		{
			hDKHECHPIGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLGMCDHAFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLGMCDHAFM(GFLGMCDHAFM other)
		: this()
	{
		hDKHECHPIGJ_ = ((other.hDKHECHPIGJ_ != null) ? other.hDKHECHPIGJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLGMCDHAFM Clone()
	{
		return new GFLGMCDHAFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFLGMCDHAFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFLGMCDHAFM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HDKHECHPIGJ, other.HDKHECHPIGJ))
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
		if (hDKHECHPIGJ_ != null)
		{
			num ^= HDKHECHPIGJ.GetHashCode();
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
		if (hDKHECHPIGJ_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HDKHECHPIGJ);
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
		if (hDKHECHPIGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HDKHECHPIGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFLGMCDHAFM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hDKHECHPIGJ_ != null)
		{
			if (hDKHECHPIGJ_ == null)
			{
				HDKHECHPIGJ = new JAFPMLLOGDI();
			}
			HDKHECHPIGJ.MergeFrom(other.HDKHECHPIGJ);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (hDKHECHPIGJ_ == null)
			{
				HDKHECHPIGJ = new JAFPMLLOGDI();
			}
			input.ReadMessage(HDKHECHPIGJ);
		}
	}
}
