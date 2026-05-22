using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSwitchMascotDataCsReq : IMessage<GetSwitchMascotDataCsReq>, IMessage, IEquatable<GetSwitchMascotDataCsReq>, IDeepCloneable<GetSwitchMascotDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetSwitchMascotDataCsReq> _parser = new MessageParser<GetSwitchMascotDataCsReq>(() => new GetSwitchMascotDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CPMOOKFKBEGFieldNumber = 3;

	private uint cPMOOKFKBEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSwitchMascotDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSwitchMascotDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPMOOKFKBEG
	{
		get
		{
			return cPMOOKFKBEG_;
		}
		set
		{
			cPMOOKFKBEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataCsReq(GetSwitchMascotDataCsReq other)
		: this()
	{
		cPMOOKFKBEG_ = other.cPMOOKFKBEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataCsReq Clone()
	{
		return new GetSwitchMascotDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSwitchMascotDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSwitchMascotDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CPMOOKFKBEG != other.CPMOOKFKBEG)
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
		if (CPMOOKFKBEG != 0)
		{
			num ^= CPMOOKFKBEG.GetHashCode();
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
		if (CPMOOKFKBEG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CPMOOKFKBEG);
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
		if (CPMOOKFKBEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPMOOKFKBEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSwitchMascotDataCsReq other)
	{
		if (other != null)
		{
			if (other.CPMOOKFKBEG != 0)
			{
				CPMOOKFKBEG = other.CPMOOKFKBEG;
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
				CPMOOKFKBEG = input.ReadUInt32();
			}
		}
	}
}
