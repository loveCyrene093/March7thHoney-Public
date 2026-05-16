using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LIDKGPCEDHE : IMessage<LIDKGPCEDHE>, IMessage, IEquatable<LIDKGPCEDHE>, IDeepCloneable<LIDKGPCEDHE>, IBufferMessage
{
	private static readonly MessageParser<LIDKGPCEDHE> _parser = new MessageParser<LIDKGPCEDHE>(() => new LIDKGPCEDHE());

	private UnknownFieldSet _unknownFields;

	public const int FPKADJBDBPOFieldNumber = 10;

	private GNLMENKBHLE fPKADJBDBPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LIDKGPCEDHE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LIDKGPCEDHEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE FPKADJBDBPO
	{
		get
		{
			return fPKADJBDBPO_;
		}
		set
		{
			fPKADJBDBPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIDKGPCEDHE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIDKGPCEDHE(LIDKGPCEDHE other)
		: this()
	{
		fPKADJBDBPO_ = ((other.fPKADJBDBPO_ != null) ? other.fPKADJBDBPO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIDKGPCEDHE Clone()
	{
		return new LIDKGPCEDHE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LIDKGPCEDHE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LIDKGPCEDHE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FPKADJBDBPO, other.FPKADJBDBPO))
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
		if (fPKADJBDBPO_ != null)
		{
			num ^= FPKADJBDBPO.GetHashCode();
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
		if (fPKADJBDBPO_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(FPKADJBDBPO);
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
		if (fPKADJBDBPO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FPKADJBDBPO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LIDKGPCEDHE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fPKADJBDBPO_ != null)
		{
			if (fPKADJBDBPO_ == null)
			{
				FPKADJBDBPO = new GNLMENKBHLE();
			}
			FPKADJBDBPO.MergeFrom(other.FPKADJBDBPO);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fPKADJBDBPO_ == null)
			{
				FPKADJBDBPO = new GNLMENKBHLE();
			}
			input.ReadMessage(FPKADJBDBPO);
		}
	}
}
