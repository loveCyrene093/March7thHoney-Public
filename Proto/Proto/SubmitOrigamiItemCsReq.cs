using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubmitOrigamiItemCsReq : IMessage<SubmitOrigamiItemCsReq>, IMessage, IEquatable<SubmitOrigamiItemCsReq>, IDeepCloneable<SubmitOrigamiItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<SubmitOrigamiItemCsReq> _parser = new MessageParser<SubmitOrigamiItemCsReq>(() => new SubmitOrigamiItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IMCIKNHHEHCFieldNumber = 11;

	private uint iMCIKNHHEHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SubmitOrigamiItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SubmitOrigamiItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMCIKNHHEHC
	{
		get
		{
			return iMCIKNHHEHC_;
		}
		set
		{
			iMCIKNHHEHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitOrigamiItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitOrigamiItemCsReq(SubmitOrigamiItemCsReq other)
		: this()
	{
		iMCIKNHHEHC_ = other.iMCIKNHHEHC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubmitOrigamiItemCsReq Clone()
	{
		return new SubmitOrigamiItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SubmitOrigamiItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubmitOrigamiItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IMCIKNHHEHC != other.IMCIKNHHEHC)
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
		if (IMCIKNHHEHC != 0)
		{
			num ^= IMCIKNHHEHC.GetHashCode();
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
		if (IMCIKNHHEHC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IMCIKNHHEHC);
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
		if (IMCIKNHHEHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMCIKNHHEHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubmitOrigamiItemCsReq other)
	{
		if (other != null)
		{
			if (other.IMCIKNHHEHC != 0)
			{
				IMCIKNHHEHC = other.IMCIKNHHEHC;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IMCIKNHHEHC = input.ReadUInt32();
			}
		}
	}
}
