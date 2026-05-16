using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFOCMJNPMKD : IMessage<EFOCMJNPMKD>, IMessage, IEquatable<EFOCMJNPMKD>, IDeepCloneable<EFOCMJNPMKD>, IBufferMessage
{
	private static readonly MessageParser<EFOCMJNPMKD> _parser = new MessageParser<EFOCMJNPMKD>(() => new EFOCMJNPMKD());

	private UnknownFieldSet _unknownFields;

	public const int GMABAPBEDGFFieldNumber = 1;

	private KHHHFHEODED gMABAPBEDGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFOCMJNPMKD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFOCMJNPMKDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED GMABAPBEDGF
	{
		get
		{
			return gMABAPBEDGF_;
		}
		set
		{
			gMABAPBEDGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFOCMJNPMKD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFOCMJNPMKD(EFOCMJNPMKD other)
		: this()
	{
		gMABAPBEDGF_ = ((other.gMABAPBEDGF_ != null) ? other.gMABAPBEDGF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFOCMJNPMKD Clone()
	{
		return new EFOCMJNPMKD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFOCMJNPMKD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFOCMJNPMKD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GMABAPBEDGF, other.GMABAPBEDGF))
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
		if (gMABAPBEDGF_ != null)
		{
			num ^= GMABAPBEDGF.GetHashCode();
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
		if (gMABAPBEDGF_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GMABAPBEDGF);
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
		if (gMABAPBEDGF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GMABAPBEDGF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFOCMJNPMKD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gMABAPBEDGF_ != null)
		{
			if (gMABAPBEDGF_ == null)
			{
				GMABAPBEDGF = new KHHHFHEODED();
			}
			GMABAPBEDGF.MergeFrom(other.GMABAPBEDGF);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gMABAPBEDGF_ == null)
			{
				GMABAPBEDGF = new KHHHFHEODED();
			}
			input.ReadMessage(GMABAPBEDGF);
		}
	}
}
