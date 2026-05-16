using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournLeaveRogueCocoonSceneScRsp : IMessage<RogueTournLeaveRogueCocoonSceneScRsp>, IMessage, IEquatable<RogueTournLeaveRogueCocoonSceneScRsp>, IDeepCloneable<RogueTournLeaveRogueCocoonSceneScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournLeaveRogueCocoonSceneScRsp> _parser = new MessageParser<RogueTournLeaveRogueCocoonSceneScRsp>(() => new RogueTournLeaveRogueCocoonSceneScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AFLJJJFCBINFieldNumber = 12;

	private BFEIPELFCDF aFLJJJFCBIN_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournLeaveRogueCocoonSceneScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournLeaveRogueCocoonSceneScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF AFLJJJFCBIN
	{
		get
		{
			return aFLJJJFCBIN_;
		}
		set
		{
			aFLJJJFCBIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLeaveRogueCocoonSceneScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLeaveRogueCocoonSceneScRsp(RogueTournLeaveRogueCocoonSceneScRsp other)
		: this()
	{
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournLeaveRogueCocoonSceneScRsp Clone()
	{
		return new RogueTournLeaveRogueCocoonSceneScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournLeaveRogueCocoonSceneScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournLeaveRogueCocoonSceneScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
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
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournLeaveRogueCocoonSceneScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new BFEIPELFCDF();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 98u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new BFEIPELFCDF();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
