using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingSelectPolicyCsReq : IMessage<ChenLingSelectPolicyCsReq>, IMessage, IEquatable<ChenLingSelectPolicyCsReq>, IDeepCloneable<ChenLingSelectPolicyCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingSelectPolicyCsReq> _parser = new MessageParser<ChenLingSelectPolicyCsReq>(() => new ChenLingSelectPolicyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DGIIOGHHAAFFieldNumber = 7;

	private uint dGIIOGHHAAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingSelectPolicyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingSelectPolicyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGIIOGHHAAF
	{
		get
		{
			return dGIIOGHHAAF_;
		}
		set
		{
			dGIIOGHHAAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingSelectPolicyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingSelectPolicyCsReq(ChenLingSelectPolicyCsReq other)
		: this()
	{
		dGIIOGHHAAF_ = other.dGIIOGHHAAF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingSelectPolicyCsReq Clone()
	{
		return new ChenLingSelectPolicyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingSelectPolicyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingSelectPolicyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DGIIOGHHAAF != other.DGIIOGHHAAF)
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
		if (DGIIOGHHAAF != 0)
		{
			num ^= DGIIOGHHAAF.GetHashCode();
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
		if (DGIIOGHHAAF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DGIIOGHHAAF);
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
		if (DGIIOGHHAAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGIIOGHHAAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingSelectPolicyCsReq other)
	{
		if (other != null)
		{
			if (other.DGIIOGHHAAF != 0)
			{
				DGIIOGHHAAF = other.DGIIOGHHAAF;
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
			if (num != 56)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DGIIOGHHAAF = input.ReadUInt32();
			}
		}
	}
}
