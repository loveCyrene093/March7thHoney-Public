using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournReEnterRogueCocoonStageCsReq : IMessage<RogueTournReEnterRogueCocoonStageCsReq>, IMessage, IEquatable<RogueTournReEnterRogueCocoonStageCsReq>, IDeepCloneable<RogueTournReEnterRogueCocoonStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournReEnterRogueCocoonStageCsReq> _parser = new MessageParser<RogueTournReEnterRogueCocoonStageCsReq>(() => new RogueTournReEnterRogueCocoonStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NBDHADPNGNHFieldNumber = 12;

	private bool nBDHADPNGNH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournReEnterRogueCocoonStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournReEnterRogueCocoonStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NBDHADPNGNH
	{
		get
		{
			return nBDHADPNGNH_;
		}
		set
		{
			nBDHADPNGNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReEnterRogueCocoonStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReEnterRogueCocoonStageCsReq(RogueTournReEnterRogueCocoonStageCsReq other)
		: this()
	{
		nBDHADPNGNH_ = other.nBDHADPNGNH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReEnterRogueCocoonStageCsReq Clone()
	{
		return new RogueTournReEnterRogueCocoonStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournReEnterRogueCocoonStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournReEnterRogueCocoonStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NBDHADPNGNH != other.NBDHADPNGNH)
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
		if (NBDHADPNGNH)
		{
			num ^= NBDHADPNGNH.GetHashCode();
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
		if (NBDHADPNGNH)
		{
			output.WriteRawTag(96);
			output.WriteBool(NBDHADPNGNH);
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
		if (NBDHADPNGNH)
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
	public void MergeFrom(RogueTournReEnterRogueCocoonStageCsReq other)
	{
		if (other != null)
		{
			if (other.NBDHADPNGNH)
			{
				NBDHADPNGNH = other.NBDHADPNGNH;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NBDHADPNGNH = input.ReadBool();
			}
		}
	}
}
